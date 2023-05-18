using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Аудиоплеер
{
    /// <summary>
    /// Список полных имен файлов
    /// </summary>
    public static class Vars
    {
        public static Form1 Link;

        /// <summary>
        /// Путь к исполняемому файлу
        /// </summary>
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        public static List<string> Files = new List<string>();

        /// <summary>
        /// Текущий номер трека
        /// </summary>
        public static int CurrentTrackNumber;

        public static string GerFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
        public static void SetInputFormats()
        {
            Link.openFileDialog1.Filter = "MPEG Audio Layer III (*.mp3)|*.mp3" +
        "|OPUS Audio (*.opus)|*.opus" +
        "|OGG Vorbis Audio (*.ogg)|*.ogg";
        }
    }
}
