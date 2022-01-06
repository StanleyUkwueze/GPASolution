using System;
using GPACalculator.Commons;

namespace GPACalculator.Models
{
    public class CourseRecordExtended
    {
        public string CourseName { get; set; }
        public int CourseUnit;
        public double Score;
        public char Grade;
        public int GradeUnit;
        public int QualityPoint;
    }
}