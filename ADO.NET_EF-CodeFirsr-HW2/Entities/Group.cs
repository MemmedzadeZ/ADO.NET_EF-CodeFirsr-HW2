namespace ADO.NET_EF_CodeFirsr_HW2.Entities; 
public class Group
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<GroupCurator> GroupsCurators { get; set; }
    public List<GroupLecture> GroupsLecuters { get; set; }
    public List<GroupStudent> GroupsStudents { get; set; }
   

  
}
