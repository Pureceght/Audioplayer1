using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аудиоплеер
{
    /// <summary>
    /// Список полных имен файлов
    /// </summary>
    public static class Vars
    {
        /// <summary>
        /// Путь к исполняемому файлу
        /// </summary>
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        public static List<string> Files = new List<string>();

        public static string GerFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
