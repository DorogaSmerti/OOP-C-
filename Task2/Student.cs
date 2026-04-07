public class Student
{
    public string Name{get;set;}
    public int Age{get;set;}
    public double AverageScore{get;set;}

    public Student(string name, int age, double averageScore)
    {
        Name = name;
        Age = age;
        AverageScore = averageScore;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Average Score: {AverageScore}";
    }
}
