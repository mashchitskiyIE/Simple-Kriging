using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Kriging
{
    static class Covariation
    {
        public static double[,] Spherical(double[,] dist, double nugget, double psill, double range)
        {
            double sigma = psill + nugget;
            double[,] ans = new double[dist.GetLength(0), dist.GetLength(1)];
            for (int i = 0; i < dist.GetLength(0); i++)
            {
                for (int j = 0; j < dist.GetLength(1); j++)
                {
                    if (dist[i, j] > range)
                    {
                        ans[i, j] = 0;
                    }
                    else
                    {
                        if (dist[i, j] == 0)
                        {
                            ans[i, j] = sigma;
                        }
                        else
                        {
                            ans[i, j] = sigma - (nugget + psill * (((3 * dist[i, j] / (2 * range)) - ((Math.Pow(dist[i, j], 3)) / (2 * Math.Pow(range, 3))))));
                        }
                    }
                }
            }
            return ans;
        }

        public static double[,] Exponential(double[,] dist, double nugget, double psill, double range)
        {
            double sigma = psill + nugget;
            double[,] ans = new double[dist.GetLength(0), dist.GetLength(1)];
            for (int i = 0; i < dist.GetLength(0); i++)
            {
                for (int j = 0; j < dist.GetLength(1); j++)
                {
                    if (dist[i, j] == 0)
                    {
                        ans[i, j] = sigma;
                    }
                    else
                    {
                        ans[i, j] = psill * Math.Exp(-dist[i, j] / range);
                    }
                }
            }
            return ans;
        }
    }
}
