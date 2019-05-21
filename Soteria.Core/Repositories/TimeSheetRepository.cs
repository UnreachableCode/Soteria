using System.Collections.Generic;
using System.Linq;

namespace Soteria.Models.Repositories
{
    public class TimeSheetRepository : ITimeSheetRepository
    {
        private List<TimeSheetEntry> _toDoList;

        public TimeSheetRepository()
        {
            InitializeData();
        }

        public IEnumerable<TimeSheetEntry> All
        {
            get { return _toDoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _toDoList.Any(item => item.ID == id);
        }

        public TimeSheetEntry Find(string id)
        {
            return _toDoList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(TimeSheetEntry item)
        {
            _toDoList.Add(item);
        }

        public void Update(TimeSheetEntry item)
        {
            var todoItem = this.Find(item.ID);
            var index = _toDoList.IndexOf(todoItem);
            _toDoList.RemoveAt(index);
            _toDoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _toDoList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _toDoList = new List<TimeSheetEntry>();

            var todoItem1 = new TimeSheetEntry
            {
                ID = "6bb8a868-dba1-4f1a-93b7-24ebce87e243",
                JobLocation = "Learn app development",
                JobNumber = "Attend Xamarin University"
            };

            var todoItem2 = new TimeSheetEntry
            {
                ID = "b94afb54-a1cb-4313-8af3-b7511551b33b",
                JobLocation = "Develop apps",
                JobNumber = "Use Xamarin Studio/Visual Studio",
            };

            var todoItem3 = new TimeSheetEntry
            {
                ID = "ecfa6f80-3671-4911-aabe-63cc442c1ecf",
                JobLocation = "Publish apps",
                JobNumber = "All app stores",
            };

            _toDoList.Add(todoItem1);
            _toDoList.Add(todoItem2);
            _toDoList.Add(todoItem3);
        }
    }
}