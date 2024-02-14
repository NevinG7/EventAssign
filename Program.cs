using Delegate1._1;

class Program
{
    private static readonly UserService userService = new();

    static void Main(string[] args)
    {

        

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1.List User");
            Console.WriteLine("2.Add User");
            Console.WriteLine("3.Update User");
            Console.WriteLine("4.Remove Users");
            Console.WriteLine("5.Sort and Display Students");
            Console.WriteLine("6.Exit");

            var inp= Convert.ToInt32( Console.ReadLine());

            switch (inp)
            {
                case 1:
                    userService.GetAllUsers();
                    break;
                case 2:
                    AddUser();
                    break;
                case 3:
                    UpdateUser();
                    break;
                case 4:
                    RemoveUser();
                    break;
                case 5:
                    sorting();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;

            }
        }

    }

    static void sorting()
    {
        List<Student> oh = new List<Student>()
    {
        new Student { Id = 100, Name = "Ram", Age = 15, Score = 99 },
        new Student { Id = 121, Name = "Arjun", Age = 19, Score = 89.8 },
        new Student { Id = 101, Name = "Rahul", Age = 15, Score = 99.9 },
        new Student { Id = 102, Name = "Riya", Age = 16, Score = 78.5 }
    };

        Comparison<Student> comparison = (p1, p2) => p1.Age.CompareTo(p2.Age);
        var k = oh.ToArray();
        sorter<Student>.BubbleSort(k, comparison);

        foreach (Student s in k)
        {
            Console.WriteLine("===========");
            Console.WriteLine($"Id: {s.Id}");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Scpre: {s.Score} ");
            Console.WriteLine($"Age: {s.Age}");
            Console.WriteLine("===========");

        }
    }



    public static void RemoveUser()
    {
        Console.WriteLine("Enter Id of user to remove");
        var userID=Convert.ToInt32(Console.ReadLine());
        userService.RemoveUser(userID);
    }
    public static void UpdateUser()
    {
        Console.WriteLine("Enter User id");
        var ToUpdateId =Convert.ToInt32(Console.ReadLine());
        var user =userService.GetUserById(ToUpdateId);

        Console.Write("Enter name");
        user.Name = Console.ReadLine();
        Console.Write("Enter email");
        user.Email = Console.ReadLine();
        Console.Write("Enter contact no");
        user.Contact = Convert.ToInt32(Console.ReadLine());

    }

    public static void AddUser()
    {
        
        Console.Write("Enter name");
        var Name = Console.ReadLine();
        Console.Write("Enter email");
        var Email = Console.ReadLine();
        Console.Write("Enter contact no");
        var Contact = Convert.ToInt32(Console.ReadLine());
        var user = new User(Name, Email, Contact);
        userService.AddUser(user);
       
    }

}