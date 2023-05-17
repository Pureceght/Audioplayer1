using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аудиоплеер
{
    public static class BassLike
    {
        /// <summary>
        /// Частота дискретизации
        /// </summary>
        private static int HZ = 44100;

        /// <summary>
        /// Состояние инициализации
        /// </summary>
        public static bool InitDefaultDevice;

        /// <summary>
        /// Главный поток плеера (канал)
        /// </summary>
        public static int Stream;

        /// <summary>
        /// Громкость
        /// </summary>
        public static int Volume = 100;
    }
}
