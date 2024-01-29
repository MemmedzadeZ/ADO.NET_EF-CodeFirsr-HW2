namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Curator
{

    public int Id { get; set; } 
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<GroupCurator> GroupCurators { get; set; }

}


