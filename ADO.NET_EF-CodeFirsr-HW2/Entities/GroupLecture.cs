namespace ADO.NET_EF_CodeFirsr_HW2.Entities;

public class GroupLecture
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public int LectureId { get; set; }
    public Group Groups { get; set; }
    public Lecture Lectures { get; set;}

}
