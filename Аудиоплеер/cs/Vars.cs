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
        public static List<string> Files = new List<string>();

        public static string GerFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
