using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();
    }
}
