using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims_14
{
    class CustomerClass
    {
        public double timearrive;

        public void GetTime(int a, int b, double now)
        {
            DistributionClass ex = new DistributionClass();
            timearrive=Math.Round((ex.PPPD(a, b, now)+now),1);
        }

        public bool  IsArrive(double now)
        {
            if (now - timearrive >= 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
