using System.Reflection;
using Bootcamp_E01.types;

namespace Bootcamp_E01.Entities;

public class TaskManager
{
    public List<TaskType> TaskList { get; set; }
    
    public void printTasks(List<TaskType> list)
    {
        foreach (var task in list)
        {
            Console.WriteLine($"{task.Title}, {task.Priority}  {task.DeadLine}");
        }

    }
    
    
    
    public List<T> orderListByProperty<T>(List<T> list,params string[] propertyNames)
    {
        if (list == null || propertyNames == null || propertyNames.Length == 0)
        {
            return list;
        }

        var sortedList = list.AsQueryable();
        foreach (var propName in propertyNames)
        {
            PropertyInfo propInfo = typeof(T).GetProperty(propName);
            if (propInfo != null)
            {
                sortedList = sortedList.OrderBy(t => propInfo.GetValue(t, null));
             
             
            }
            else
            {
                Console.WriteLine($"invalid prop name {propName}");
            }
        }

        return sortedList.ToList();
    }

    
}
