using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point(int xPos, int yPos, string petName): this(xPos, yPos)
        {
            desc.PetName = petName;
        }

        //Override Object.ToString()
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}";

        //Return a copy of the current object.
        //public object Clone() => new Point(this.X, this.Y);
        //public object Clone() => this.MemberwiseClone();
        public object Clone()
        {
            //First get the shallow copy
            Point newPoint = (Point)this.MemberwiseClone();

            //Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
