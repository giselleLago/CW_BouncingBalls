using System;
using System.Collections.Generic;
using System.Text;

namespace CW_BouncingBalls
{
    public class BouncingBall
    {
        public int bouncingBall(double h, double bounce, double window)
        {
            if (bounce >= 1 || bounce <= 0 || h <= 0 || window >= h)
            {
                return -1;
            }
            else
            {
                h *= bounce;
                return 2 + bouncingBall(h, bounce, window);
            }

            /*if(h <= 0 || bounce <= 0 ||bounce >= 1 || window >= h) return -1;
            int result = -1;
  
            do{
              result+=2;
              h*=bounce;
            }while(h>window);
  
            return result;*/
        }
    }
}
