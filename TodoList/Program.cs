namespace TodoList;
class Program
{
    static void Main(string[] args)
    {
        TodoListInit();
    }

    private static void TodoListInit()
    {
        List<string> listOfTodos = new();
        while(true)
        {
            Console.Write("1. Add Tasks \n2. Mark Task as Complete\n3. Delete Tasks\n4. List All the Task\n5. Exit\n Enter your Choice");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 5) break;
            switch (choice)
            {
                case 1:
                    AddTasksToList(listOfTodos);
                    break;
                case 2:
                    MarkTaskAsCompleted(listOfTodos);
                    break;
                case 3:
                    DeleteTasksFromList(listOfTodos);
                    break;
                case 4:
                    ListAllTaskOfTodos(listOfTodos);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
    }

    private static void AddTasksToList(List<string> listOfTodos)
    {
        Console.WriteLine("Enter the Task to Add");
        var task = Console.ReadLine();
        if (task != null)
        {
            listOfTodos.Add(task);
            Console.WriteLine("Task Added to the list");
        }
        else
            Console.WriteLine("Task cannot be empty");
    }

    private static void ListAllTaskOfTodos(List<string> listOfTodos)
    {
        int index = 1;
        foreach(var tasks in listOfTodos)
        {
            Console.WriteLine($"{index}. {tasks}");
            index++;
        }
        Console.WriteLine("\n");
    }

    private static void MarkTaskAsCompleted(List<string> listOfTodos)
    {
        ListAllTaskOfTodos(listOfTodos);
        Console.WriteLine("Choose a Task that has been completed");
        int choice = Convert.ToInt32(Console.ReadLine());
        RemoveCompletedTasks(listOfTodos, choice);
        
    }


    private static void RemoveCompletedTasks(List<string> listOfTodos,int indexOfTask)
    {
        listOfTodos.RemoveAt((indexOfTask - 1));
        ListAllTaskOfTodos(listOfTodos);
    }

    private static void DeleteTasksFromList(List<string> listOfTodos)
    {
        ListAllTaskOfTodos(listOfTodos);
        Console.WriteLine("Choose a Task that you want to delete");
        int choice = Convert.ToInt32(Console.ReadLine());
        RemoveCompletedTasks(listOfTodos, choice);
    }
}

