namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class GroupStudent
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int GroupId { get; set; }
    public Student Studnets { get; set; }
    public Group Groups { get; set; }

}
