using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GPACalculator.Models;

namespace GPACalculator.Data.Repositories.Interface.InMemory
{
    public interface IInMemoryRepository : ICRUDReository
    {
        Task<List<CourseRecord>> GetCourseRecordsByEntryNumberAsync(int entryNumber);

        //Task<List<CourseRecord>> GetCourseRecordsAsync();
        //Task<CourseRecord> GetCourseRecord(string id);
    }
}
