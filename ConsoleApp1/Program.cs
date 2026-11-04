using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher MrNinh = new Teacher("Ninh", 176, 80, true, "GV103");

            Student MrVuong = new Student("Vuong", 175, 68, true, "5612.68");
            Student MrQuan = new Student ("Quan", 170, 70, true, "5613.68");

            MrNinh.showMyIdentity();
            MrNinh.showPersonalInformation();
            Console.WriteLine();

            MrVuong.showMyIdentity();
            MrVuong.showPersonalInformation();
            Console.WriteLine();

            MrQuan.showMyIdentity();
            MrQuan.showPersonalInformation();

            Console.ReadLine();
        }
    }
}
