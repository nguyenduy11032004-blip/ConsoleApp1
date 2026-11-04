using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher : Person
    {
        public string teacherID;
        public Teacher(string _name, int _height, int _weight, bool _ismale, string _teacherID) : base(_name, _height, _weight, _ismale)
        {
            this.teacherID = _teacherID;
        }
        public override void showMyIdentity()
        {
            Console.WriteLine("Toi ten la " + this.name + ", toi la giao vien. ");
        }
    }
}
