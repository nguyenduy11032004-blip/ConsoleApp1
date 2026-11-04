using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public int height;
        public int weight;
        public bool ismale;
        public Person (string _name, int _height, int _weight, bool _ismale)
        {
            this.name = _name;
            this.height = _height;
            this.weight = _weight;
            this.ismale = _ismale;
        }

        public virtual void showMyIdentity()
        {
            Console.WriteLine("Toi ten la " + this.name + ", Toi la robot. ");
        }

        public void showPersonalInformation()
        {
            Console.WriteLine("Toi ten la " + this.name + ", chieu cao cua toi la " + this.height + ", can nang cua toi la " + this.weight + ", gioi tinh cua toi la " + this.ismale);
            if(this.ismale== true)
            {
                Console.WriteLine("Toi la nam");
            }
            else
            {
                Console.WriteLine("Toi la nu");
            }
        }
    }
}
