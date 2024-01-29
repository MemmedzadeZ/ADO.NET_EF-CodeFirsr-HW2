namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Teacher
{
    public int Id { get; set; }
    public bool IsProfessor { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Surname { get; set; }

    public List<Lecture> Lectures { get; set;}

}
