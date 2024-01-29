using Microsoft.EntityFrameworkCore;
using ADO.NET_EF_CodeFirsr_HW2.Entities;
namespace ADO.NET_EF_CodeFirsr_HW2.Contexts;

public  class QueryLibsDBContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string strcon = "Data Source=DESKTOP-QOMBEIP;Initial Catalog=LibsSubDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(strcon);
        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupCurators { get; set; }
    public DbSet<GroupLecture> GroupLecture { get; set;}
    public DbSet<GroupStudent> GroupStudents { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }




}
