using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GPACalculator.Data.Repositories.InMemory;
using GPACalculator.Data.Repositories.Interface.InMemory;
using GPACalculator.Models;

namespace GPACalculator.Data.Repositories.Implementations.InMemory
{
    public class InMemoryRepository : IInMemoryRepository
    {

        public Task<bool> AddAsync<T>(List<T> entities)
        {
            int numberOfRowsBefore = this.RowCount();

            foreach(var entity in entities)
            {
                var record = entity as CourseRecord;
                InMemoryStorage.CourseRecords.Add(record);
            }

            int numberOfRowsAfter = this.RowCount();

            if (numberOfRowsAfter <= numberOfRowsBefore)
                return Task.Run(() => false);

            return Task.Run(() => true);
        }


      
        public Task<List<CourseRecord>> GetCourseRecordsByEntryNumberAsync(int entryNumber)
        {
            int numberOfRows = this.RowCount();

            if (numberOfRows < 1)
                throw new Exception("No record found, table is empty!");

            var recordsWithSameEntryNumber = new List<CourseRecord>();
            int backCounter = (numberOfRows - 1);
            for(int i = 0; i < numberOfRows; i++)
            {
                if(InMemoryStorage.CourseRecords[i].inputEntryNumber.Equals(entryNumber))
                {
                    recordsWithSameEntryNumber.Add(InMemoryStorage.CourseRecords[i]);
                }

                if (InMemoryStorage.CourseRecords[backCounter].inputEntryNumber.Equals(entryNumber))
                {
                    recordsWithSameEntryNumber.Add(InMemoryStorage.CourseRecords[backCounter]);
                }
                backCounter--;
            }


            if (recordsWithSameEntryNumber.Equals(null))
                throw new Exception($"No record found with {entryNumber}");

            return Task.Run(() => recordsWithSameEntryNumber);

        }


        public Task<HashSet<int>> GetEntryNumbersDistinctAsync()
        {
            if (this.RowCount() < 1)
                throw new Exception("No record found, table is empty!");

            var distinctValues = new HashSet<int>();
            foreach(var item in InMemoryStorage.CourseRecords)
            {
                distinctValues.Add(item.inputEntryNumber);
            }

            return Task.Run(() => distinctValues) ;
        }


        public Task<bool> RemoveAsync<T>(List<T> entities)
        {
            int numberOfRowsBefore = this.RowCount();
            if (numberOfRowsBefore < 1)
                throw new Exception("No record found, table is empty!");

            foreach (var entity in entities)
            {
                var record = entity as CourseRecord;
                if (InMemoryStorage.CourseRecords.Contains(record))
                    InMemoryStorage.CourseRecords.Remove(record);
            }

            int numberOfRowsAfter = this.RowCount();
            if (numberOfRowsAfter >= numberOfRowsBefore)
                return Task.Run(() => false);

            return Task.Run(() => true);
        }


        public int RowCount()
        {
            return InMemoryStorage.CourseRecords.Count;
        }
    }
}
