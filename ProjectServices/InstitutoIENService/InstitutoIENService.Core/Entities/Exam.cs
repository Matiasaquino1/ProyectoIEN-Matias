﻿namespace InstitutoIENService.Core.Entities;

public partial class Exam : BaseEntity
{
    public decimal TestScore { get; set; }

    public string Condition { get; set; } = null!;

    public int StudenId { get; set; }

    public int SubjectId { get; set; }

    public int ProfessorId { get; set; }

    public string ExamType { get; set; } = null!;

    public DateTime ExamDate { get; set; }

    public TimeSpan ExamTime { get; set; }

    public string IsAbsent { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Professor Professor { get; set; } = null!;
}
