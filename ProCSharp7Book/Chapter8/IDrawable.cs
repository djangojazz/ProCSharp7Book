using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    interface IDrawable
    {
        void Draw();
    }

    interface IPrintable
    {
        void Print();
        void Draw(); // <-- possible name clash here.
    }

    //Multiple interface inheritance. OK!
    interface IShape: IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
