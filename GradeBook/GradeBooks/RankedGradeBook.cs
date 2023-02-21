using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public  class RankedGradeBook : BaseGradeBook 
    {
        public RankedGradeBook(string name) : base (name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            switch (averageGrade) {
                case 0.2: return'A';
                case double i when i > 0.2 && i < 0.4: return 'B';
                case double i when i > 0.4 && i < 0.6 : return 'C';
                case double i when i > 0.6 && i < 0.8: return 'C';

                default: return 'F';
            }

            
        }
    }
}
