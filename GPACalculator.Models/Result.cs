using System.Collections.Generic;

namespace GPACalculator.Models
{
    public class Result
    {
        public List<CourseRecordExtended> CourseRecords;
        public string GPA;

        public Result()
        {
            CourseRecords = new List<CourseRecordExtended>();
        }
    }
}