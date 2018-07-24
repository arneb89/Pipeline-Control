using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Control
{
    class Repers
    {
        double[] pixels;
        int[] orders;
        double[] lambdas;
        double[] diviations;
        int repers_count = 0;

        public double[][] pixels_ord = null;
        public double[][] lambda_ord = null;
        public double[][] diviat_ord = null;

        public Repers(string path)
        {
            StreamReader sr = new StreamReader(path);
            int lines_number;
            string str;

            lines_number = -1;
            do
            {
                lines_number++;
                str = sr.ReadLine();
            } while (str != null && str != "");
            sr.Close();

            this.repers_count = lines_number;

            sr = new StreamReader(path);
            string[] strMas;

            this.orders = new int[this.repers_count];
            this.lambdas = new double[this.repers_count];
            this.pixels = new double[this.repers_count];
            this.diviations = new double[this.repers_count];
            

            for (int i = 0; i < this.repers_count; i++)
            {
                str = sr.ReadLine();
                strMas = str.Split(new string[] { " ", "\t" }, 
                    StringSplitOptions.RemoveEmptyEntries);
                orders[i] = int.Parse(strMas[0]);
                pixels[i] = double.Parse(strMas[1]) + 1;
                lambdas[i] = double.Parse(strMas[2]);
                diviations[i] = double.Parse(strMas[3]);
            }
            sr.Close();

            this.pixels_ord = new double[orders.Max()+1][];
            this.lambda_ord = new double[orders.Max()+1][];
            this.diviat_ord = new double[orders.Max() + 1][];

            for (int i = 0; i < this.pixels_ord.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < this.orders.Length; j++)
                {
                    if (orders[j] == i) k++;
                }
                this.pixels_ord[i] = new double[k];
                this.lambda_ord[i] = new double[k];
                this.diviat_ord[i] = new double[k];
            }
            for (int i = 0; i < this.pixels_ord.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < this.orders.Length; j++)
                {
                    if (orders[j] == i)
                    {
                        this.pixels_ord[i][k] = pixels[j];
                        this.lambda_ord[i][k] = lambdas[j];
                        this.diviat_ord[i][k] = diviations[j];
                        k++;
                    }
                }
            }
        }

        public int FindLine(int order, double pixel_approx, double lambda_approx)
        {
            double pix, lam, r, r0 = 0;
            int i0 = 0;

            pix = this.pixels_ord[order][0];
            lam = this.lambda_ord[order][0];
            r0 = Math.Pow(pix - pixel_approx, 2) + Math.Pow(lam - lambda_approx, 2);
            for (int i = 1; i < pixels_ord[order].Length; i++)
            {
                pix = this.pixels_ord[order][i];
                lam = this.lambda_ord[order][i];
                r = Math.Pow(pix - pixel_approx, 2) + Math.Pow(lam - lambda_approx, 2);
                if (r < r0)
                {
                    r0 = r;
                    i0 = i;
                }
            }
            return i0;
        }

        public int FindLine(int order, double pixel_approx)
        {
            double pix, r, r0 = 0;
            int i0 = 0;

            pix = this.pixels_ord[order][0];
            r0 = Math.Abs(pixel_approx - pix);
            for (int i = 1; i < pixels_ord[order].Length; i++)
            {
                pix = this.pixels_ord[order][i];
                r = Math.Abs(pixel_approx - pix);
                if (r < r0)
                {
                    r0 = r;
                    i0 = i;
                }
            }
            return i0;
        }
    }
}
