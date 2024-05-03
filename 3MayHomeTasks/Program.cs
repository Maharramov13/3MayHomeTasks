using _3MayHomeTasks;

internal class Program
{   
    static List<Student> students = new List<Student>();
    static List<Employee> employees = new List<Employee>();
    public static void Main(string[] args)
    {
        students.Add(new Student("Zahid", "Mammadov", 27, 85));
        students.Add(new Student("Akbar", "Aliyev", 27, 78));
        employees.Add(new Employee("Elshad", "Hasanli", 26, "Boss"));
        employees.Add(new Employee("Famil", "İsmayilov", 27, "Engineer"));
        employees.Add(new Employee("Vuqar", "Maharramov", 32, "Boss"));
        students.Add(new Student("Hikmet", "Xidirzade", 25, 57));

        while (true)
        {
            Console.WriteLine("\nMake your choice:");
            Console.WriteLine("1-Add new Student");
            Console.WriteLine("2-Add new Employee");
            Console.WriteLine("3-Search ");
            Console.WriteLine("4-Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddEmployee();
                    break;
                case "3":
                    SearchMenu();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Wrong choice,Please enter number beetwen 1-4.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Surname:");
        string surname = Console.ReadLine();
        
        age: int age;
        try
        {
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("enter  age correctly");
            goto age;
        }
        Console.WriteLine("Enter grade ");
        int grade = Convert.ToInt32(Console.ReadLine());

        Student student = new Student(name, surname, age, grade);
        students.Add(student);
        Console.WriteLine("Student Added.");
       

    }

   public static void AddEmployee()
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the surname:");
        string surname = Console.ReadLine();

    age:
        int age;
        try
        {
            Console.WriteLine(" Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("enter your age correctly");
            goto age;
        }
        
        Console.WriteLine(" Enter position:");
        string position = Console.ReadLine();

        Employee employee = new Employee(name, surname, age, position);
        employees.Add(employee);
        Console.WriteLine("Employee added.");
    }

    public static void SearchMenu()
    {
        Console.WriteLine("\n Seraching choice:");
        Console.WriteLine("1-Searching for employees");
        Console.WriteLine("2-Searching for Students");

        string searchChoice = Console.ReadLine();

        switch (searchChoice)
        {
            case "1":
                SearchEmployeeByPosition();
                break;
            case "2":
                SearchStudentByGrade();
                break;
            default:
                Console.WriteLine("wrong choice.");
                break;
        }
    }

   public static void SearchEmployeeByPosition()
    {
        Console.WriteLine("Select the position you want to search for:");
        string position = Console.ReadLine();

        List<string> foundEmployees = new List<string>();
        foreach (Employee employee in employees)
        {
            if (employee.Position == position)
            {
                foundEmployees.Add($"{employee.Name} {employee.Surname}");
            }
        }
        

        if (foundEmployees.Count > 0)
        {
            Console.WriteLine("Found Employees:");
            foreach (string empName in foundEmployees)
            {
                Console.WriteLine(empName);
            }
        }
        else
        {
            Console.WriteLine("could not find any employee .");
        }
        
           
    }

   public static void SearchStudentByGrade()
    {
        Console.WriteLine("Min grade degree:");
        int minGrade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Max grade degree:");
        int maxGrade = Convert.ToInt32(Console.ReadLine());

        List<string> foundStudents = new List<string>();
        foreach (Student student in students)
        {
            if (student.Grade >= minGrade && student.Grade <= maxGrade)
            {
                foundStudents.Add($"{student.Name} {student.Surname} - {student.Grade}");
            }
        }

        if (foundStudents.Count > 0)
        {
            Console.WriteLine("Finded Students:");
            foreach (string stuInfo in foundStudents)
            {
                Console.WriteLine(stuInfo);
            }
        }
        else
        {
            Console.WriteLine("Coludn't finnd any student.");
        }
    }
}
    
