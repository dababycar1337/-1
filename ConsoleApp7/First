using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7;
namespace ConsoleApp7
namespace ConsoleApp7
{
    class First
    {
        Random rnd = new Random();
        private int[] array;
        private int _length;
        private float _middle;
        private int[] _lowerarray;
        private int[] _norepeatarray;
        public First(int length, bool qwer = false)
        {
            _length = length;
            array = new int[_length];
            if (!qwer)
            {
                for (int i = 0; i < _length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    array[i] = rnd.Next(-200, 201);
                }
            }
        }

        public void Writeall()
        {
            Console.Write("Одномерный массив: ");
            for (int i = 0; i < _length; i++)
            {
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine("");


            Console.WriteLine("Среднее арифметическое: " + _middle);
            if (_lowerarray != null)
            {
                Console.Write("Массив с элементами меньше 100 по модулю: ");
                for (int i = 0; i < _length; i++)
                {
                    if (_lowerarray[i] != null)
                    {
                        Console.Write(_lowerarray[i] + "; ");
                    }
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Все элементы массива больше или равны 100 по модулю");
            }


            Console.Write("Массив без повторений: ");
            for (int i = 0; i < _length; i++)
            {
                if (_norepeatarray[i] != null)
                {
                    Console.Write(_norepeatarray[i] + "; ");
                }

            }
            Console.WriteLine("");
        }

        public void FindMiddle()
        {
            _middle = 0;
            for (int i = 0; i < _length; i++)
            {
                _middle += array[i];
            }
            _middle = _middle / _length;
            Console.WriteLine(_middle);
        }

        public void OnlyLower()
        {
            _lowerarray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                if ((array[i] < 100) && (array[i] > -100))
                {
                    _lowerarray[i] = array[i];
                }
            }
            for(int i = 0; i < _lowerarray.Length; i++)
            {
                Console.Write(_lowerarray[i] + " ");
            }
            Console.WriteLine("");
        }

        public void NoRepeat()
        {
            _norepeatarray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                int c = array[i];
                for (int j = 0; j < _length; j++)
                {
                    if (i != j && c == array[j])
                    {
                        array[j] = 0;
                        _norepeatarray[i] = c;
                    }
                    else
                    {
                        _norepeatarray[i] = c;
                    }
                }
            }

            for (int i = 0; i < _norepeatarray.Length; i++)
            {
                Console.Write(_norepeatarray[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}

