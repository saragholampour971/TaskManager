using Bootcamp_E01.Entities;
using Bootcamp_E01.types;

List<TaskType> myTasks=new List<TaskType>()
{
  new (){Title = "1 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(1),Priority = Priority.Low}, 
  new (){Title = "4 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(4),Priority = Priority.Medium}, 
  new (){Title = "2 day",Description = "kjadkfja",DeadLine = DateTime.Today.AddDays(2),Priority = Priority.High} 
};


TaskManager groupTaskOne = new()
{
  TaskList = myTasks
};


groupTaskOne.printTasks(groupTaskOne.orderListByProperty(groupTaskOne.TaskList,"DeadLine","Priority"));






