using System;
using System.Collections.Generic;
using GPACalculator.Models;

namespace GPACalculator.Data.Repositories.InMemory
{
    public class InMemoryStorage
    {
        public static List<CourseRecord> CourseRecords { get; set; } = new List<CourseRecord>();
    }
}
