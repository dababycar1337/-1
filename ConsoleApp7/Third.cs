using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7;
namespace ConsoleApp7
{
  class Third
    {
        Random rnd = new Random();
        private float middletog;
        private float[] middledif;
        private int[][] array;
        private int _length;
        private int[][] multiarray;
        public Third(int length, bool qwer)
        {
            array = new int[length][];
            int[] dop;
            _length = length;
            if (!qwer)
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.WriteLine("Сколько элементов будет в данной вложенной строке?");
                    int c = int.Parse(Console.ReadLine());
                    dop = new int[c];
                    Console.WriteLine("Введите " + c + " элементов");
                    for (int j = 0; j < c; j++)
                    {
                        dop[j] = int.Parse(Console.ReadLine());
                    }
                    array[i] = dop;
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    for (int j = 0; j < rnd.Next(1, 4); j++)
                    {
                        array[i][j] = rnd.Next(-200, 201);
                    }
                }
            }
        }

        public void MultiArrayMaker()
        {
            multiarray = new int[_length][];
            for (int i = 0; i < _length; i++)
            {
                multiarray[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    ;
                    if (array[i][j] % 2 == 0)
                    {
                        multiarray[i][j] = (i + 1) * (j + 1);
                    }
                    else
                    {
                        multiarray[i][j] = array[i][j];
                    }
                }
            }

            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < multiarray[i].Length; j++)
                {
                    Console.Write(multiarray[i][j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public void Middletog()
        {
            middletog = 0;
            int dop = 0;
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    middletog += array[i][j];
                }
                dop += array[i].Length;
            }
            middletog = middletog / dop;
            Console.WriteLine(middletog);
        }

        public void MiddleDif()
        {
            middledif = new float[_length];
            float middle = 0;
            for (int i = 0; i < _length; i++)
            {
                middle = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    middle += array[i][j];
                }
                middledif[i] = middle / array[i].Length;
            }

            int c = 1;
            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine(c + " строка: " + middledif[i]);
                c++;
            }
            Console.WriteLine("");

        }

        public void WriteAll()
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Среднее арифметическое всего массива: ");
            Console.WriteLine(middletog);

            Console.WriteLine("Средние арифметические каждой вложенной строки: ");
            int c = 1;
            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine(c + " строка: " + middledif[i]);
                c++;
            }

            Console.WriteLine("Массив, у которого чётные элементы изменены на произведения их индексов: ");
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < multiarray[i].Length; j++)
                {
                    Console.Write(multiarray[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
