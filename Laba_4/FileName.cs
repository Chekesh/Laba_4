using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Reader
    {
        private string FIO;
        public int TicketNumber;
        public string Faculty;
        private string BirthDate;
        private string Telephone;
        public Reader(string FIO, int TicketNumber, string Faculty, string BirthDate, string Telephone)
        {
            this.FIO = FIO;
            this.TicketNumber = TicketNumber;
            this.Faculty = Faculty;
            this.BirthDate = BirthDate;
            this.Telephone = Telephone;
        }

        public void takeBook(int kol) { Console.WriteLine(FIO + " взял " + kol + " книги"); }
        public void takeBook(String[] name)
        {
            String books = String.Join(",", name);
            Console.WriteLine(FIO + " взял книги:" + books);
        }
        public void returnBook(int kol) { Console.WriteLine(FIO + " вернул " + kol + " книги"); }
        public void returnBook(String[] name)
        {
            String books = String.Join(",", name);
            Console.WriteLine(FIO + " вернул книги:" + books);
        }
    }
}
