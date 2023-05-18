using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;
using System.Windows.Forms;

namespace Аудиоплеер
{
    public static class BassLike
    {
        /// <summary>
        /// Частота дискретизации
        /// </summary>
        public static int HZ = 44100;
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
        //^^^ПЕРЕМЕННЫЕ^^^//
        private static readonly List<int> BassPluginsHandles = new List<int>();    
        public static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_tta.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassape.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassdsd.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassmidi.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswv.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < BassPluginsHandles.Count; i++)
                        if (BassPluginsHandles[i] == 0)
                            ErrorCount++;
                    if(ErrorCount != 0)
                        MessageBox.Show(ErrorCount + " плагина(ов) не было загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ErrorCount = 0;
                }
            }






            return InitDefaultDevice;
        }
        /// <summary>
        /// Воспроизведение
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="vol"></param>
        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }

                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
        }
        /// <summary>
        /// Стоп
        /// </summary>
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
        }
        /// <summary>
        /// Получение длительности канала в секундах
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }
        /// <summary>
        /// Получение текущей позиции в секундах
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        /// <summary>
        /// Установка громкости
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="vol"></param>
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
    }
}
