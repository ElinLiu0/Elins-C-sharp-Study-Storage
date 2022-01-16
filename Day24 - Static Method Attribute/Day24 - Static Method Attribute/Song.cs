using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24___Static_Method_Attribute
{
    public class Song
    {
        public string title;
        public string artist;
        public int duration;
        // 静态属性是指作用于所有类下对下的属性值，有且仅为唯一值
        public static int songCount = 0;
        public Song(string aTitle,string aArtist,int aDuartion)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuartion;
            // 在歌曲被创建时，静态属性将被重赋值并追加
            songCount++;
        }
    }
}
