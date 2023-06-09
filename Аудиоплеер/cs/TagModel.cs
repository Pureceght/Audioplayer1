﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;
namespace Аудиоплеер
{
    public class TagModel
    {
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;
        public TagModel(string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);
            Artist = tagInfo.artist;
            Album = tagInfo.album;
            if (tagInfo.title == "")
                Title = Vars.GerFileName(file);
            else
                Title = tagInfo.title;
            Year = tagInfo.year;
        }
    }
}
