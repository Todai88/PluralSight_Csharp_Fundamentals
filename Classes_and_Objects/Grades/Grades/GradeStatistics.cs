using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {

        private GradeBook _gradeBook;
        private float _minGrade;
        private float _maxGrade;
        private float _average;
        public GradeStatistics(GradeBook gb)
        {
            _gradeBook = gb;
        }

        public void ComputeStatistics()
        {
            List<float> grades = _gradeBook.getGrades();

            _minGrade = grades.Min();
            _maxGrade = grades.Max();
            _average  = grades.Average();
        }

        public string PrintStats()
        {
            return string.Format("Min:{0}\nMax:{1}\nAvg:{2}",
                _minGrade, _maxGrade, _average);
        }
    }
}
