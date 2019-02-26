using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14.CarLibrary
{
    //Represents the state of the engine.
    public enum EngineState
    {
        engineAlive,
        engineDead
    }

    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }
    
    //The abstract base class in the hierarchy.
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState engState = EngineState.engineAlive;
        public EngineState EngineState => engState;
        public abstract void TurboBoost();
        public void TurnOnRadio(bool musicOn, MusicMedia mm) =>
            MessageBox.Show(musicOn ? $"Jamming {mm}" : "Quiet time...");


        public Car() => MessageBox.Show("CarLibrary Version 2.0!");
        public Car(string name, int maxSp, int currSp)
        {
            MessageBox.Show("CarLibrary Version 2.0!");
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }
    }

}
