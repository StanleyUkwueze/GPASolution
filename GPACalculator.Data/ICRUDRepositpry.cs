using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GPACalculator.Data
{
    public interface ICRUDReository
    {
        Task<bool> AddAsync<T>(List<T> entities);
        Task<bool> RemoveAsync<T>(List<T> entities);
        int RowCount();
        Task<HashSet<int>> GetEntryNumbersDistinctAsync();
    }
}
