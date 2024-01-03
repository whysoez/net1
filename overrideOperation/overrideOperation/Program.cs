using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var run = new Program();
            run.Insert();
            Console.ReadKey();
        }

        private void Insert()
        {
            Console.Write("Enter number elements: ");
            int n = int.Parse(Console.ReadLine());
            List<Fraction> list = new List<Fraction>();
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter value of Faction {0}:\t", i + 1);
                string value = Console.ReadLine();
                var valueResult = value.Split(' ');
                Fraction item = new Fraction(int.Parse(valueResult[0]), int.Parse(valueResult[1]));
                list.Add(item);
            }
            Sort(list);
        }
        private void Sort(List<Fraction> arr)
        {
            

            for(int i = 0; i < arr.Count-1; i++)
            {
                for(int j = i+1; j < arr.Count; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        Fraction temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Show(arr);
        }
        private void Show(List<Fraction> arr)
        {
            Console.WriteLine("List after sort : ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0}/{1}\t", arr[i].num, arr[i].den);
            }
        }
    }


    internal class Fraction
    {
        public int num;
        public int den;
        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.num * b.den > b.num * a.den;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.num * b.den < b.num * a.den;
        }
    }
}
