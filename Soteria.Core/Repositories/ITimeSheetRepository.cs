using System.Collections.Generic;

namespace Soteria.Models.Repositories
{
    public interface ITimeSheetRepository
    {
        bool DoesItemExist(string id);
        IEnumerable<TimeSheetEntry> All { get; }
        TimeSheetEntry Find(string id);
        void Insert(TimeSheetEntry item);
        void Update(TimeSheetEntry item);
        void Delete(string id);
    }
}
