using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamA_Tentamen.Models
{
    public class GetCurrentSpeed
    {
        public double CurrentSpeed(double distance, double time)
        {
            if (distance < 0)
                throw new Exception("Dictance must be over 0");
            if (time < 0)
                throw new Exception("Dictance must be over 0");

            return distance/time;
        }
    }
}
