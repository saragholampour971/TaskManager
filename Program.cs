using System.Reflection;
using Bootcamp_E01.types;

List<TaskType> myTasks=new List<TaskType>()
{
  new (){Title = "1 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(1),Priority = Priority.Low}, 
  new (){Title = "4 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(4),Priority = Priority.Medium}, 
  new (){Title = "2 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(2),Priority = Priority.High} 
};


 List<T> orderListByProperty<T>(List<T> list,params string[] propertyNames)
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

void printTasks(List<TaskType> list)
{
    foreach (var task in list)
{
   Console.WriteLine($"{task.Title}, {task.Priority}  {task.DeadLine}");
}

}

var result = orderListByProperty(myTasks,"DeadLine","Priority");
printTasks(result);







