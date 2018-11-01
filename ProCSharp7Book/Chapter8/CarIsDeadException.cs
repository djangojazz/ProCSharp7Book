using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    [Serializable]
    public class CarIsDeadException: ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarIsDeadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public CarIsDeadException(string message, string cause, DateTime time): base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
