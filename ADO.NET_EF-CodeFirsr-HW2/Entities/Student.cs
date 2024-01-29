namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Surname { get; set; }

    public List<GroupStudent> GroupStudents { get;set; }

}
