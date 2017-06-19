using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private List<float> _grades;
        private int _minGrade = 0;
        private int _maxGrade = 100;

        public GradeBook()
        {
            _grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        public List<float> getGrades()
        {
            return _grades;
        }
    }
}
