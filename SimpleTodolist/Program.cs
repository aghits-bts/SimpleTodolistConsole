namespace SimpleTodolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TodoList Program!");

            List<string> todoList = new List<string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nTodoList Console");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. View TodoList");
                Console.WriteLine("3. Update Todo");
                Console.WriteLine("4. Remove Todo");
                Console.WriteLine("5. Exit");
                Console.Write("Select Option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nAdd Todo");
                        Console.Write("Please enter the task: ");
                        string todo = Console.ReadLine();
                        todoList.Add(todo);
                        Console.WriteLine("Add todo successfully.");
                        break;

                    case "2":
                        Console.WriteLine("\nView TodoList");
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("TodoList is empty, please add todo first!.");
                        }
                        else
                        {
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nUpdate Todo");
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("TodoList is empty, please add todo first!.");
                        }
                        else
                        {
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }

                            Console.Write("\nPlease enter todo id: ");
                            int id;
                            if (int.TryParse(Console.ReadLine(), out id) && id > 0 && id <= todoList.Count)
                            {
                                Console.Write("Please enter the task: ");
                                todoList[id-1] = Console.ReadLine();
                                Console.WriteLine("Update todo successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid id.");
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nRemove Todo");
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("TodoList is empty, please add todo first!.");
                        }
                        else
                        {
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }

                            Console.Write("\nPlease enter todo id: ");
                            int id;
                            if (int.TryParse(Console.ReadLine(), out id) && id > 0 && id <= todoList.Count)
                            {
                                todoList.RemoveAt(id-1);
                                Console.WriteLine("Remove todo successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid id.");
                            }
                        }
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            Console.WriteLine("\nThank you for using TodoList Console, se you soon :)");
        }
    }
}