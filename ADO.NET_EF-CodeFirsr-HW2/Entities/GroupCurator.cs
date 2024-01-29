namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class GroupCurator
{
    public int Id { get; set; }
    public int CuratorId { get; set; }
    public int GroupId { get; set; }
    public Curator Curators { get; set; }
    public Group Groups { get; set; }

}
