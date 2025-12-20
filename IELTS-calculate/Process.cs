using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTS_calculate
{
    public class Process
    {
        public double Listening;
        public double Reading;
        public double Writing;
        public double Speaking;
        public double result;
       public double CalculateOveral(double listening,double reading, double writing, double speaking)
        {
            this.Listening = listening;
            this.Reading = reading;
            this.Writing = writing;
            this.Speaking = speaking;

            double overall = (Listening + Reading + Writing + Speaking)/4.0;
            int result=(int)Math.Truncate(overall);
            if (overall - result >= 0.25 && overall - result < 0.75)
            {
                return result + 0.5;
            }
            else if (overall - result >= 0.75)
            {
                return result + 1.0;
            }
            else
            {
                return result;
            }


        }

    }
}
