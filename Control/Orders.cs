using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Control
{
    class Orders
    {
        int orders_count = 0;
        double[][] flux = null;
        int[] pixels = null;
        public Orders(string path)
        {
            StreamReader sr = new StreamReader(path);
            int orders_count;
            int pixes_count;

            string str;
            string[] strMas;
            str = sr.ReadLine();
            strMas = str.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            orders_count = strMas.Length - 1;
            pixes_count = LinesCounter(path);

            this.orders_count = orders_count;

            this.flux = new double[orders_count][];
            for (int i = 0; i < orders_count; i++) this.flux[i] = new double[pixes_count];

            this.pixels = new int[pixes_count];
            
            int count=0;
            while (count <= pixes_count - 1)
            {
                strMas = str.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                this.pixels[count] = int.Parse(strMas[0]);
                for (int i = 0; i < orders_count; i++)
                {
                    this.flux[i][count] = double.Parse(strMas[i + 1].Replace(".", ","));
                }
                str = sr.ReadLine();
                count++;
            }
            sr.Close();
        }

        private int LinesCounter(string file_name)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(file_name);
            int lines_number;
            string str;

            lines_number = -1;
            do
            {
                lines_number++;
                str = sr.ReadLine();
            } while (str != null && str != "");
            sr.Close();
            return lines_number;
        }

        public double Flux(int order, int pixel_num)
        {
            return this.flux[order][pixel_num];
        }

        public double[][] Fluxes
        {
            get
            {
                return this.flux;
            }
        }

        public int[] Pixels
        {
            get
            {
                return this.pixels;
            }
        }

        public int OrdersCount
        {
            get
            {
                return this.orders_count;
            }
        }
    }
}
