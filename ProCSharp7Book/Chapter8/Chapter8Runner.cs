using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    public static class Chapter8Runner
    {
        public static void InterfaceClashes()
        {
            Console.WriteLine("****** Fun with Interface Name Clashes ****\n");
            Octagon o = new Octagon();

            //Long form
            IDrawToForm idrawToForm = (IDrawToForm)o;
            idrawToForm.Draw();

            //Shorter form
            ((IDrawToPrinter)o).Draw();

            //Using the 'is a' methodology
            if(o is IDrawToMemory dtm)
                dtm.Draw();
        }
    }
}
