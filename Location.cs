using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public abstract class Location
    {//맵을 만들어줄 클래스
        public string Name {  get; set; }
        protected Location(string name) 
        {
            Name = name;
        }
    }
}
