namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Lecture> Lectures { get; set;}
}
