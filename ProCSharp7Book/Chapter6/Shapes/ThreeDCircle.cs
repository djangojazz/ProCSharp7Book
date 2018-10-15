using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class ThreeDCircle : Circle
    {
        //Hide the PetName property above me.
        public new string PetName { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
