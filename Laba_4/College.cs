using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colleg
{
    internal class Student
    {
        public string FIO;
        public string GroupNumber;
        private int Age;
        public Student(string FIO, string GroupNumber, int Age)
        {
            this.FIO = FIO;
            this.GroupNumber = GroupNumber;
            this.Age = Age;
        }

        public void Print()
        {
            Console.WriteLine($"ФИО: {FIO } \nГруппа: {GroupNumber} \nВозраст: {Age}");
        }
    }
}
