namespace Lab1;

public enum Gender
{
    Man,
    Woman,
    Mixed
}

public class Student
{
    public String name { get; set; }
    public Gender gender { get; set; }
    public String eyeColor { get; set; }
    public int age { get; set; }

    public void Add(Student stud)
    {
        gender = stud.gender == this.gender ? stud.gender : Gender.Mixed;
        name += stud.name;
        eyeColor += stud.eyeColor;
        age += stud.age;
    }
}