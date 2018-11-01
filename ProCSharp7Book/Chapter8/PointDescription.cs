using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    //This class describes a point.
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "No-Name";
            PointID = Guid.NewGuid();
        }
    }
}
