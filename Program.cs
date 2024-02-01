using Bootcamp_E01.Entities;
using Bootcamp_E01.types;

List<TaskType> myTasks=new List<TaskType>()
{
  new (){Title = "1 day",Description = "kjadkfja",DeadLine = DateTime.Parse("2024-02-01"),CompletionDate =DateTime.Parse("2024-01-10"),IsCompleted = true,Priority = Priority.Low}, 
  new (){Title = "4 day",Description = "kjadkfja",DeadLine = DateTime.Parse("2024-03-10"),CompletionDate = DateTime.Parse("2024-02-01"),IsCompleted = true,Priority = Priority.Medium}, 
  new (){Title = "2 day",Description = "kjadkfja",DeadLine = DateTime.Parse("2024-01-01"),CompletionDate = null,IsCompleted = false,Priority = Priority.High} 
};


TaskManager groupTaskOne = new()
{
  TaskList = myTasks
};



groupTaskOne.printTasks(groupTaskOne.orderListByProperty(groupTaskOne.TaskList,"DeadLine","Priority"));


        int totalTasks = myTasks.Count();

        int completedTasks = myTasks.Count(t => t.IsCompleted);

        DateTime fromDate = DateTime.Parse("2024-01-01");
        DateTime toDate = DateTime.Parse("2024-01-04");
        int completedTasksInDateRange = myTasks.Count(t => t.IsCompleted && t.CompletionDate >= fromDate && t.CompletionDate <= toDate);

        int inprogressTasks = myTasks.Count(t => !t.IsCompleted);

       
        int overdueTasks = myTasks.Count(t => !t.IsCompleted && t.CreatedAt.AddDays(5) <= DateTime.Now);

        var overdueUncompletedTasks = myTasks.Where(t => !t.IsCompleted && (DateTime.Now - t.CreatedAt).TotalDays > 5).OrderByDescending(t => t.CreatedAt).Take(3);

        var tasksDonedAtOneDay = myTasks.Where(t => t.IsCompleted && t.CreatedAt.Date == t.CompletionDate.Value.Date).OrderByDescending(t => t.CreatedAt).Take(3);

        var inprogressTaskWithPriority = myTasks.Where(t => !t.IsCompleted).GroupBy(t => t.Priority).Select(g => new { Priority = g.Key, Count = g.Count() });





