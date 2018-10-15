using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Circle : Shape
    {
        public Circle() {}
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the circle");
        }
    }
}
