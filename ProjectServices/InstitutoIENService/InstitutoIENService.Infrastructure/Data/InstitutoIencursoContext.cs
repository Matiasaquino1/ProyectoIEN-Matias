using InstitutoIENService.Core.Entities;
using InstitutoIENService.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Data;

public partial class InstitutoIencursoContext : DbContext
{
    public InstitutoIencursoContext()
    {
    }

    public InstitutoIencursoContext(DbContextOptions<InstitutoIencursoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrative> Administratives { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<RrhhCategory> RrhhCategories { get; set; }

    public virtual DbSet<Commission> Commissions { get; set; }

    public virtual DbSet<CommissionDetail> CommissionsDetails { get; set; }

    public virtual DbSet<MaritalStatus> MatiralsStatus { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Locality> Localities { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectTopic> SubjectsTopics { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<OperationRole> OperationsRole { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<StudyPlan> StudiesPlans { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    public virtual DbSet<ProfessorSubject> ProfessorsSubjects { get; set; }

    public virtual DbSet<ProfessorTitle> ProfessorsTitles { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Rrhh> Rrhhs { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdministrativeConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new ClassroomConfiguration());
        modelBuilder.ApplyConfiguration(new CareerConfiguration());
        modelBuilder.ApplyConfiguration(new CommissionConfiguration());
        modelBuilder.ApplyConfiguration(new RrhhCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CommissionDetailConfiguration());
        modelBuilder.ApplyConfiguration(new MaritalStatusConfiguration());
        modelBuilder.ApplyConfiguration(new ExamConfiguration());
        modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
        modelBuilder.ApplyConfiguration(new LocalityConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectTopicConfiguration());
        modelBuilder.ApplyConfiguration(new ModuleConfiguration());
        modelBuilder.ApplyConfiguration(new NotificationConfiguration());
        modelBuilder.ApplyConfiguration(new OperationConfiguration());
        modelBuilder.ApplyConfiguration(new OperationRoleConfiguration());
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new StudyPlanConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorSubjectConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorTitleConfiguration());
        modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new RrhhConfiguration());
        modelBuilder.ApplyConfiguration(new TopicConfiguration());
        modelBuilder.ApplyConfiguration(new TitleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());


    }


}
