using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Colleg.Student[] students = { new Colleg.Student("Чекушин Н.С", "21ИТ17", 18),
                                        new Colleg.Student("Вапилин Д.М", "21ИТ17", 19),
                                        new Colleg.Student("Доброходов А.В", "21ИТ17", 17)};
            Library.Reader[] readers = { new Library.Reader("Ильясов И.И", 123, "Механика", "20.03.2006", "89273885180"),
                                            new Library.Reader("Белесов М.Б", 132, "Программирование", "14.12.2005", "8927546354"),
                                            new Library.Reader("Титов И.Д", 100, "Веб-разработка", "15.07.2005", "89276574387")};
            
            foreach (Library.Reader reader in readers)              
                {
                int kol = Convert.ToInt32(Console.ReadLine());
                reader.takeBook(kol);
                String[] book = new String[kol];
                for (int y = 0; y < kol; y++)
                {
                    Console.WriteLine((y + 1) + ": ");
                    String namebook = Console.ReadLine();
                    book[y] = namebook;
                }
                reader.takeBook(book);
            }
            Console.Read();
        }
    }
}
