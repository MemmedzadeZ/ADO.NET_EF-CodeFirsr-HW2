namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class Lecture
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int SubjectId { get; set; }
    public int TeacherId { get; set; }
    public Subject Subject { get; set; }
    public Teacher Teacher { get; set;}

    public List<GroupLecture> GroupLectures { get; set;}
   


}
