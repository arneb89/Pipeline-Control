using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control
{
    class DataTable
    {
        public double[][] Data = null;

        public DataTable(string path)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(path);

            int lines_number, columns_number;
            string str;
            string[] strMas;

            lines_number = this.LinesCounter(path);
            columns_number = this.ColumnsCounter(path);

            this.Data = new double[columns_number][];
            for (int i = 0; i < columns_number; i++) 
                this.Data[i] = new double[lines_number];

            sr = new System.IO.StreamReader(path);
            for (int i = 0; i < lines_number; i++)
            {
                str = sr.ReadLine();
                strMas = str.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < columns_number; j++)
                {
                    this.Data[j][i] = double.Parse(strMas[j].Replace(".", ","));
                }
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

        private int ColumnsCounter(string file_name)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(file_name);
            int columns_number;
            string str = sr.ReadLine();
            string[] strMas;
            strMas = str.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            columns_number = strMas.Length;
            sr.Close();
            return columns_number;
        }
    }
}
