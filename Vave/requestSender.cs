﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using CUETools.Codecs;
using CUETools.Codecs.FLAKE;

namespace Vave
{
    public static class requestSender
    {
        public enum TextType
        {
            ComboBox = 1,
            VideoList = 2,
            ResponseList = 3
        }

        /// <summary>
        /// Deneme
        /// </summary>
        /// <param name="_filename">Bu parametre dosya adını alır.</param>
        public static string Send(FileInfo _filename)
        {
            string _flac = _filename.DirectoryName + "\\temporary.flac";
            int sampleRate = 0;
            IAudioSource audioSource = new WAVReader(_filename.FullName, null);
            AudioBuffer buff = new AudioBuffer(audioSource, 65536);
            FlakeWriter flakewriter = new FlakeWriter(_flac, audioSource.PCM);
            sampleRate = audioSource.PCM.SampleRate;
            while (audioSource.Read(buff, -1) != 0)
                flakewriter.Write(buff);
            flakewriter.Close();
            audioSource.Close();//sanırım wav dosyasına erişim hatasına neden olan şey bunun eksikliği :))))
            return GoogleSpeechRequest(_flac, sampleRate);
        }

        private static string GoogleSpeechRequest(string _flacname, int _samplerate)
        {
            WebRequest request = WebRequest.Create("https://www.google.com/speech-api/full-duplex/v1/up?key=AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw&pair=" + GenerateUnique(16) + "&lang=tr-TR&client=chromium&continuous&interim&pFilter=0&maxAlternatives=10");
            request.Method = "POST";
            byte[] byteArray = File.ReadAllBytes(_flacname);
            request.ContentType = "audio/x-flac; rate=" + _samplerate;
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        private static string GenerateUnique(int length)
        {
            string[] LETTERS = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] DIGITS = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string buffer = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int rnd = random.Next(2);
                if (rnd == 1)
                    buffer += LETTERS[random.Next(LETTERS.Length)];
                else
                    buffer += DIGITS[random.Next(DIGITS.Length)];
            }
            return buffer;
        }
    }
}