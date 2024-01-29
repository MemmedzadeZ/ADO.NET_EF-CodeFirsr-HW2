namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Department
{
    public int Id { get; set; }
    public int Building { get; set; }
    public decimal Financing { get; set; }
    public string Name { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get;set; }



    public List<Group> Groups { get; set; }
}
