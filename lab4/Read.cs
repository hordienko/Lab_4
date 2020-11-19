using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab4
{
    class Read
    {
        static double[,] exp1;
        static double[,] exp2;
        static double[,] exp3;
        static double[,] exp4;
        static string[] book;
        static string[] parametr;
        static double[] weight;
        public static double[,] Expert1() // метод для зчитування і запису чисел в масив 
        {
            string filePath = Path.GetFullPath("1.txt");
            int y = 0;
            using var fileReader = new StreamReader(filePath);
            string line;
            exp1 = new double[5, 4];
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] lines = line.Split(' ');
                double[] mas = new double[4];

                for (int i = 0; i < 4; i++)
                {
                    exp1[y, i] = Convert.ToDouble(lines[i]);
                }
                y++;
            }
            return exp1;
        }


        public static double[,] Expert2()  
        {
            string filePath = Path.GetFullPath("2.txt");
            int y = 0;
            using var fileReader = new StreamReader(filePath);
            string line;
            exp2 = new double[5, 4];
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] lines = line.Split(' ');
                double[] mas = new double[4];

                for (int i = 0; i < 4; i++)
                {
                    exp2[y, i] = Convert.ToDouble(lines[i]);
                }
                y++;
            }
            return exp2;
        }

        public static double[,] Expert3() 
        {
            string filePath = Path.GetFullPath("3.txt");
            int y = 0;
            using var fileReader = new StreamReader(filePath);
            string line;
            exp3 = new double[5, 4];
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] lines = line.Split(' ');
                double[] mas = new double[4];

                for (int i = 0; i < 4; i++)
                {
                    exp3[y, i] = Convert.ToDouble(lines[i]);
                }
                y++;
            }
            return exp3;
        }

        public static double[,] Expert4() 
        {
            string filePath = Path.GetFullPath("4.txt");
            int y = 0;
            using var fileReader = new StreamReader(filePath);
            string line;
            exp4 = new double[5, 4];
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] lines = line.Split(' ');
                double[] mas = new double[4];

                for (int i = 0; i < 4; i++)
                {
                    exp4[y, i] = Convert.ToDouble(lines[i]);
                }
                y++;
            }
            return exp4;
        }


        public static string[] Book() 
        {
            string filePath = Path.GetFullPath("book.txt");

            using var fileReader = new StreamReader(filePath);
            string file = fileReader.ReadToEnd();
            string[] lines = file.Split('\n');


            book = new string[lines.Length];

            for (int i = 0; i < book.Length; i++)
            {
                book[i] = lines[i];
            }
            return book;
        }

        public static string[] Parametrs() 
        {
            string filePath = Path.GetFullPath("param.txt");

            using var fileReader = new StreamReader(filePath);
            string file = fileReader.ReadToEnd();
            string[] lines = file.Split('\n');


            parametr = new string[lines.Length];

            for (int i = 0; i < parametr.Length; i++)
            {
                parametr[i] = lines[i];
            }
            return parametr;
        }
        public static double[] GetWeight() // метод для зчитування і запису чисел в масив 
        {
            string filePath = Path.GetFullPath("Weight.txt");

            using var fileReader = new StreamReader(filePath);
            string file = fileReader.ReadToEnd();
            string[] lines = file.Split('\n');


            weight = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                weight[i] = Convert.ToDouble(lines[i]);
                //Console.WriteLine($"{i} {fileProp[i]}");
            }
            return weight;
        }
    }
}
