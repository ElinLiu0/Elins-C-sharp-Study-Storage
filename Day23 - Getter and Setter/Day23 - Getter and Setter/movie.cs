using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23___Getter_and_Setter
{
    public class movie
    {
        public string Tittle;
        public string Director;
        // 相较于internal而言，private的限制要求更高，即：仅限当前类下的构造方法有权获取该属性值
        private string Rating;
        // 此时通过movie类型数据获取到的三个实参将优先传递给上方的三个属性
        public movie(string aTitle,string aDirector,string aRating)
        {
            Tittle = aTitle;
            Director = aDirector;
            rating = aRating;
        }
        // 在同类对数据原始性质进行修改
        // 此时rating的getter获取器和setter设置器将从Rating中获取对象值
        public string rating
        {
            // get方法来获取目标属性值
            get { return Rating; }
            // 获取到的对象目标将进行条件判断，当满足条件时，setter将会工作，并对原始值做出更改
            set 
            {
                // 为setter添加限制条件
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    Rating = value;
                } else
                {
                    Rating = "NR";
                }
            }
        }
    }
}
