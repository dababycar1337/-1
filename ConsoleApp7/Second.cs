using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7;
namespace ConsoleApp7
{
  class Second
    {
        Random rnd = new Random();
        private int[,] array;
        private int _length1;
        private int _length2;
        private float _middle;
        private int[,] reversearray;
        public Second(int length1, int length2, bool qwer = false)
        {
            _length1 = length1;
            _length2 = length2;
            array = new int[_length1, _length2];
            int dop = 1;
            if (!qwer)
            {
                for (int i = 0; i < _length1; i++)
                {
                    Console.WriteLine("Введите элементы " + dop + " строки");
                    for (int j = 0; j < _length2; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                    dop++;
                }
            }
            else
            {
                for (int i = 0; i < _length1; i++)
                {
                    for (int j = 0; j < _length2; j++)
                    {
                        array[i, j] = rnd.Next(-200, 201);
                    }
                }
            }
        }

        public void FindMiddle()
        {
            _middle = 0;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    _middle += array[i, j];
                }
            }
            int c = _length1 * _length2;
            _middle = _middle / c;
            Console.WriteLine(_middle);
        }


        public void Reversewriting()
        {
            reversearray = new int[_length1, _length2];
            int w = 0;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (w % 2 == 0)
                    {
                        reversearray[i, j] = array[i, j];
                    }
                    else
                    {
                        reversearray[i, j] = array[i, _length2 - 1 - j];
                    }
                }

                w++;
            }
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (reversearray[i, j] != null)
                    {
                        Console.Write(reversearray[i, j] + " ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public void WriteAll()
        {
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (array[i, j] != null)
                    {
                        Console.Write(array[i, j] + " ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("Двумерный массив с чётными перевёрнутыми строками: ");
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (reversearray[i, j] != null)
                    {
                        Console.Write(reversearray[i, j] + " ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("Среднее арифметическое всего массива: ");
            Console.Write(_middle);
            Console.WriteLine("");
        }
    }
}
