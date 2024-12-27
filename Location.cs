using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    public abstract class Location
    {//각 맵을 상속시켜 사용하려고 했으나.... 내가 만들고자 했던 게임은 월드맵이 없는 통짜형 구조였다..
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int MapType { get; protected set; }
        protected Location(string name, string description , int maptype)
        {
            Name = name;
            Description = description;
            MapType = maptype;
        }

        public abstract void MapNamespace();
    }
}
