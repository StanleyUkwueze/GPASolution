using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GPACalculator.Models;

namespace GPACalculator.Data.Repositories.File.Interface
{
    public interface IFileRepository : ICRUDReository
    {
        Task<List<CourseRecord>> GetCourseRecordsByEntryNumberAsync(int entryNumber);
    }
}
