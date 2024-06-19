using _06._12._2024_2_;



Console.Write("Enter your full name: ");
string fullname = Console.ReadLine();
Console.Write("Enter your email: ");
string email = Console.ReadLine();

User user = null;
while (user == null)
{
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();
    user = new User(fullname, email, password);
    if (user.Password == null)
    {
        user = null;
        Console.WriteLine("Please enter a valid password.");
    }
}

Group group = null;

while (group == null)
{
    Console.Write("Enter group number: ");
    string groupNo = Console.ReadLine();
    Console.Write("Enter student limit: ");
    int studentLimit = int.Parse(Console.ReadLine());
    group = new Group(groupNo, studentLimit);
    if (group.GroupNo == null)
    {
        group = null;
        Console.WriteLine("Please enter a valid group number and student limit.");
    }
}

while (true)
{
    Console.WriteLine("Group Menu:");
    Console.WriteLine("1. Show all students");
    Console.WriteLine("2. Get student by id");
    Console.WriteLine("3. Add student");
    Console.WriteLine("0. Quit");
    string groupChoice = Console.ReadLine();

    if (groupChoice == "1")
    {
        foreach (var student in group.GetAllStudents())
        {
            student.StudentInfo();
        }
    }
    else if (groupChoice == "2")
    {
        Console.Write("Enter student id: ");
        int id = int.Parse(Console.ReadLine());
        Student student = group.GetStudent(id);
        if (student != null)
        {
            student.StudentInfo();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
    else if (groupChoice == "3")
    {
        Console.Write("Enter student fullname: ");
        string studentFullname = Console.ReadLine();
        Console.Write("Enter student point: ");
        float studentPoint = float.Parse(Console.ReadLine());

        Student newStudent = new Student(studentFullname, studentPoint);
        group.AddStudent(newStudent);
    }
    else if (groupChoice == "0")
    {
        break;
    }
}