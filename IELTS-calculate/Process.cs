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
            result = Math.Round(overall * 2) / 2;
            return result;
        }

    }
}
