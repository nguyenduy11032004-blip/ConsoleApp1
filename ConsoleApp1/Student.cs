using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        public string studentID;
        public Student(string _name, int _height, int _weight, bool _ismale, string _studentID) : base(_name, _height, _weight, _ismale)
        {
            this.studentID = _studentID;
        }
        public override void showMyIdentity()
        {
            Console.WriteLine("Toi ten la " + this.name + ", toi la hoc sinh. ");
        }
    }
}