using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name = "NoName") : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the hexagon");
        }
    }
}
