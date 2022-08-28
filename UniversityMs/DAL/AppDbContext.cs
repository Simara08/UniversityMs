using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Models;

namespace UniversityMs.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Mezun> Mezunlar { get; set; }
        public DbSet<RektorPage> Rektorlar { get; set; }
        public DbSet<Prorektorpage> Prorektorlar { get; set; }
        public DbSet<Elmishurapage> Elmishuralar { get; set; }
        public DbSet<Newspage> Newspages { get; set; }
        public DbSet<Aboutpage> Aboutpages { get; set; }
        public DbSet<SeminarUser> SeminarUser { get; set; }
        public DbSet<Googlemap> Maps { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Assigment> Assigment { get; set; }
        public DbSet<ResearchProject> ResearchProject { get; set; }
        public DbSet<AssigmentCourseSection> AssigmentCourseSection { get; set; }
        public DbSet<AssigmentUser> AssigmentUser { get; set; }
        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassCourse> ClassCourse { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDep> CourseDep { get; set; }
        public DbSet<CourseQuiz> CourseQuiz { get; set; }
        public DbSet<CourseSturucture> CourseSturucture { get; set; }
        public DbSet<CourseTopic> CourseTopic { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Depfaculty> Depfaculty { get; set; }
        public DbSet<DepUser> DepUser { get; set; }
        public DbSet<DocLogs> DocLogs { get; set; }
        public DbSet<DocTranskript> DocTranskript { get; set; }
        public DbSet<DocArayish> DocArayish { get; set; }
        public DbSet<DocErize> DocErize { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamCourseStruc> ExamCourseStruc { get; set; }
        public DbSet<ExamPaper> ExamPaper { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<FacultyCourseStruc> FacultyCourseStruc { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<GradePoint> GradePoint { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Paper> Paper { get; set; }
        public DbSet<UniProgram> Program { get; set; }
        public DbSet<ResearchTopic> ResearchTopic { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Seminar> Seminar { get; set; }
        public DbSet<Semestr> Semestr { get; set; }
        public DbSet<SemOffering> SemOffering { get; set; }
        public DbSet<SemOffCourse> SemOffCourse { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TimeSchedule> TimeSchedule { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<UniProject> UniProject { get; set; }
        public DbSet<UserExam> UserExam { get; set; }
        public DbSet<UserQuiz> UserQuiz { get; set; }
        public DbSet<UserSectionCourseStruc> UserSectionCourseStruc { get; set; }
        public DbSet<SectionCourseStruc> SectionCourseStruc { get; set; }
    }
}
