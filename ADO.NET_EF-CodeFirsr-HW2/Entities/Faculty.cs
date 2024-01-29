namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Faculty
{
    public int Id { get; set; }
    public string Name { get; set; }

    List<Department> Departments { get; set; }
}
