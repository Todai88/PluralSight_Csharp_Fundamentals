using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeBook book2 = new GradeBook();
            book2.AddGrade(54);
            book2.AddGrade(32.5f);

            GradeStatistics bookStats = new GradeStatistics(book);
            bookStats.ComputeStatistics();

            Console.WriteLine(bookStats.PrintStats());
        }
    }
}
