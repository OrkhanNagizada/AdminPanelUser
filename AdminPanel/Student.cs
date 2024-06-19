namespace _06._12._2024_2_;

public class Student
{
    private static int studentIdCounter = 1;
    private readonly int id;
    public string Fullname { get; set; }
    public float Point { get; set; }

    public Student(string fullname, float point)
    {
        this.id = studentIdCounter++;
        this.Fullname = fullname;
        this.Point = point;
    }

    public int Id => id;

    public void StudentInfo()
    {
        Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
    }
}