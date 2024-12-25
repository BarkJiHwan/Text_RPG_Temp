using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    public abstract class Location
    {//맵을 만들어줄 클래스
        public string Name { get; protected set; }
        public string Description { get; protected set; }        
        protected Location(string name, string description)
        {
            Name = name;
            Description = description;            
        }
        public abstract void MapNamespace();
    }
}
