using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14.CarLibrary
{
    public class Minivan : Car
    {
        public Minivan() { }
        public Minivan(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }

        public override void TurboBoost()
        {
            engState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your engine block exploded!");
        }
    }
}
