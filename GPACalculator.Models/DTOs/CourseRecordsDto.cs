using System.Collections.Generic;

namespace GPACalculator.Models.DTOs
{
    public class CourseRecordsDto
    {
        public List<CourseRecord> CourseRecords { get; set; }


        public CourseRecordsDto()
        {
            CourseRecords = new List<CourseRecord>();
        }
    }
}
