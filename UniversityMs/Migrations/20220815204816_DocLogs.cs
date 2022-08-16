using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class DocLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_AssigmentCourseSection_Assigment_AssigmentId",
                table: "AssigmentCourseSection");

            migrationBuilder.DropForeignKey(
                name: "FK_AssigmentUser_Assigment_AssigmentId",
                table: "AssigmentUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Class_ClassId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Course_CourseId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDep_Course_CourseId",
                table: "CourseDep");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseQuiz_Quiz_QuizId",
                table: "CourseQuiz");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSturucture_Course_CourseId",
                table: "CourseSturucture");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTopic_Course_CourseId",
                table: "CourseTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTopic_Topic_TopicId",
                table: "CourseTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Department_DepartmentId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Faculty_FacultyId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_DepUser_Department_DepId",
                table: "DepUser");

            migrationBuilder.DropForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Class_ClassId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamCourseStruc_Exam_ExamId",
                table: "ExamCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamPaper_Exam_ExamId",
                table: "ExamPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamPaper_Paper_PaperId",
                table: "ExamPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_FacultyCourseStruc_Faculty_FacultyId",
                table: "FacultyCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_SectionCourseStruc_CourseSectionId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_GradePoint_Grade_GradeId",
                table: "GradePoint");

            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Class_ClassId",
                table: "Quiz");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_UniProject_ProjectId",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProjeck_SectionCourseStruc_CourseSectionId",
                table: "ResearchProjeck");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProjeck_Faculty_FacultyId",
                table: "ResearchProjeck");

            migrationBuilder.DropForeignKey(
                name: "FK_RProjectPaper_Paper_PaperId",
                table: "RProjectPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_RProjectPaper_ResearchProjeck_RProjectId",
                table: "RProjectPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_RTopicUser_ResearchTopic_RTopicId",
                table: "RTopicUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_SemOffering_SemOfferingId",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseStruc_CourseSturucture_CourseStrucId",
                table: "SectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseStruc_Section_SectionId",
                table: "SectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_Semestr_SemOffering_SemOfferingId",
                table: "Semestr");

            migrationBuilder.DropForeignKey(
                name: "FK_Seminar_Class_ClassId",
                table: "Seminar");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffCourse_Course_CourseId",
                table: "SemOffCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffCourse_SemOffering_SemOfferingId",
                table: "SemOffCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffering_Department_DepartmentId",
                table: "SemOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSchedule_Class_ClassId",
                table: "TimeSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_UniProject_SectionCourseStruc_CourseSectionId",
                table: "UniProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UniProject_Faculty_FacultyId",
                table: "UniProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExam_Exam_ExamId",
                table: "UserExam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuiz_Quiz_QuizId",
                table: "UserQuiz");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSectionCourseStruc_SectionCourseStruc_CourseSectionId",
                table: "UserSectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSectionCourseStruc_Status_StatusId",
                table: "UserSectionCourseStruc");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Faculty",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocLogsId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TranskriptId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocTranskript",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTranskript", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    TranskriptId = table.Column<int>(nullable: false),
                    ArayishId = table.Column<int>(nullable: false),
                    ErizeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocLogs_DocArayish_ArayishId",
                        column: x => x.ArayishId,
                        principalTable: "DocArayish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocLogs_DocErize_ErizeId",
                        column: x => x.ErizeId,
                        principalTable: "DocErize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocLogs_DocTranskript_TranskriptId",
                        column: x => x.TranskriptId,
                        principalTable: "DocTranskript",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DocLogsId",
                table: "AspNetUsers",
                column: "DocLogsId",
                unique: true,
                filter: "[DocLogsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TranskriptId",
                table: "AspNetUsers",
                column: "TranskriptId",
                unique: true,
                filter: "[TranskriptId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DocLogs_ArayishId",
                table: "DocLogs",
                column: "ArayishId");

            migrationBuilder.CreateIndex(
                name: "IX_DocLogs_ErizeId",
                table: "DocLogs",
                column: "ErizeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocLogs_TranskriptId",
                table: "DocLogs",
                column: "TranskriptId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Class_ClassId",
                table: "AspNetUsers",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DocLogs_DocLogsId",
                table: "AspNetUsers",
                column: "DocLogsId",
                principalTable: "DocLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DocTranskript_TranskriptId",
                table: "AspNetUsers",
                column: "TranskriptId",
                principalTable: "DocTranskript",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssigmentCourseSection_Assigment_AssigmentId",
                table: "AssigmentCourseSection",
                column: "AssigmentId",
                principalTable: "Assigment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssigmentUser_Assigment_AssigmentId",
                table: "AssigmentUser",
                column: "AssigmentId",
                principalTable: "Assigment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Class_ClassId",
                table: "ClassCourse",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Course_CourseId",
                table: "ClassCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDep_Course_CourseId",
                table: "CourseDep",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseQuiz_Quiz_QuizId",
                table: "CourseQuiz",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSturucture_Course_CourseId",
                table: "CourseSturucture",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTopic_Course_CourseId",
                table: "CourseTopic",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTopic_Topic_TopicId",
                table: "CourseTopic",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Department_DepartmentId",
                table: "Depfaculty",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Faculty_FacultyId",
                table: "Depfaculty",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepUser_Department_DepId",
                table: "DepUser",
                column: "DepId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Class_ClassId",
                table: "Exam",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamCourseStruc_Exam_ExamId",
                table: "ExamCourseStruc",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamPaper_Exam_ExamId",
                table: "ExamPaper",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamPaper_Paper_PaperId",
                table: "ExamPaper",
                column: "PaperId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FacultyCourseStruc_Faculty_FacultyId",
                table: "FacultyCourseStruc",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_SectionCourseStruc_CourseSectionId",
                table: "Grade",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradePoint_Grade_GradeId",
                table: "GradePoint",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Class_ClassId",
                table: "Quiz",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_UniProject_ProjectId",
                table: "ProjectUser",
                column: "ProjectId",
                principalTable: "UniProject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProjeck_SectionCourseStruc_CourseSectionId",
                table: "ResearchProjeck",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProjeck_Faculty_FacultyId",
                table: "ResearchProjeck",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RProjectPaper_Paper_PaperId",
                table: "RProjectPaper",
                column: "PaperId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RProjectPaper_ResearchProjeck_RProjectId",
                table: "RProjectPaper",
                column: "RProjectId",
                principalTable: "ResearchProjeck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTopicUser_ResearchTopic_RTopicId",
                table: "RTopicUser",
                column: "RTopicId",
                principalTable: "ResearchTopic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_SemOffering_SemOfferingId",
                table: "Section",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseStruc_CourseSturucture_CourseStrucId",
                table: "SectionCourseStruc",
                column: "CourseStrucId",
                principalTable: "CourseSturucture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseStruc_Section_SectionId",
                table: "SectionCourseStruc",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Semestr_SemOffering_SemOfferingId",
                table: "Semestr",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seminar_Class_ClassId",
                table: "Seminar",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffCourse_Course_CourseId",
                table: "SemOffCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffCourse_SemOffering_SemOfferingId",
                table: "SemOffCourse",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffering_Department_DepartmentId",
                table: "SemOffering",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSchedule_Class_ClassId",
                table: "TimeSchedule",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniProject_SectionCourseStruc_CourseSectionId",
                table: "UniProject",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniProject_Faculty_FacultyId",
                table: "UniProject",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExam_Exam_ExamId",
                table: "UserExam",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuiz_Quiz_QuizId",
                table: "UserQuiz",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSectionCourseStruc_SectionCourseStruc_CourseSectionId",
                table: "UserSectionCourseStruc",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSectionCourseStruc_Status_StatusId",
                table: "UserSectionCourseStruc",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Class_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DocLogs_DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DocTranskript_TranskriptId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_AssigmentCourseSection_Assigment_AssigmentId",
                table: "AssigmentCourseSection");

            migrationBuilder.DropForeignKey(
                name: "FK_AssigmentUser_Assigment_AssigmentId",
                table: "AssigmentUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Class_ClassId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Course_CourseId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDep_Course_CourseId",
                table: "CourseDep");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseQuiz_Quiz_QuizId",
                table: "CourseQuiz");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSturucture_Course_CourseId",
                table: "CourseSturucture");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTopic_Course_CourseId",
                table: "CourseTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTopic_Topic_TopicId",
                table: "CourseTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Department_DepartmentId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Faculty_FacultyId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_DepUser_Department_DepId",
                table: "DepUser");

            migrationBuilder.DropForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Class_ClassId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamCourseStruc_Exam_ExamId",
                table: "ExamCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamPaper_Exam_ExamId",
                table: "ExamPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamPaper_Paper_PaperId",
                table: "ExamPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_FacultyCourseStruc_Faculty_FacultyId",
                table: "FacultyCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_SectionCourseStruc_CourseSectionId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_GradePoint_Grade_GradeId",
                table: "GradePoint");

            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Class_ClassId",
                table: "Quiz");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_UniProject_ProjectId",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProjeck_SectionCourseStruc_CourseSectionId",
                table: "ResearchProjeck");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProjeck_Faculty_FacultyId",
                table: "ResearchProjeck");

            migrationBuilder.DropForeignKey(
                name: "FK_RProjectPaper_Paper_PaperId",
                table: "RProjectPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_RProjectPaper_ResearchProjeck_RProjectId",
                table: "RProjectPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_RTopicUser_ResearchTopic_RTopicId",
                table: "RTopicUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_SemOffering_SemOfferingId",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseStruc_CourseSturucture_CourseStrucId",
                table: "SectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseStruc_Section_SectionId",
                table: "SectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_Semestr_SemOffering_SemOfferingId",
                table: "Semestr");

            migrationBuilder.DropForeignKey(
                name: "FK_Seminar_Class_ClassId",
                table: "Seminar");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffCourse_Course_CourseId",
                table: "SemOffCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffCourse_SemOffering_SemOfferingId",
                table: "SemOffCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffering_Department_DepartmentId",
                table: "SemOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSchedule_Class_ClassId",
                table: "TimeSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_UniProject_SectionCourseStruc_CourseSectionId",
                table: "UniProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UniProject_Faculty_FacultyId",
                table: "UniProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExam_Exam_ExamId",
                table: "UserExam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuiz_Quiz_QuizId",
                table: "UserQuiz");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSectionCourseStruc_SectionCourseStruc_CourseSectionId",
                table: "UserSectionCourseStruc");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSectionCourseStruc_Status_StatusId",
                table: "UserSectionCourseStruc");

            migrationBuilder.DropTable(
                name: "DocLogs");

            migrationBuilder.DropTable(
                name: "DocTranskript");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TranskriptId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TranskriptId",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssigmentCourseSection_Assigment_AssigmentId",
                table: "AssigmentCourseSection",
                column: "AssigmentId",
                principalTable: "Assigment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssigmentUser_Assigment_AssigmentId",
                table: "AssigmentUser",
                column: "AssigmentId",
                principalTable: "Assigment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Class_ClassId",
                table: "ClassCourse",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Course_CourseId",
                table: "ClassCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDep_Course_CourseId",
                table: "CourseDep",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseQuiz_Quiz_QuizId",
                table: "CourseQuiz",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSturucture_Course_CourseId",
                table: "CourseSturucture",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTopic_Course_CourseId",
                table: "CourseTopic",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTopic_Topic_TopicId",
                table: "CourseTopic",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Department_DepartmentId",
                table: "Depfaculty",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Faculty_FacultyId",
                table: "Depfaculty",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepUser_Department_DepId",
                table: "DepUser",
                column: "DepId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Class_ClassId",
                table: "Exam",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamCourseStruc_Exam_ExamId",
                table: "ExamCourseStruc",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamPaper_Exam_ExamId",
                table: "ExamPaper",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamPaper_Paper_PaperId",
                table: "ExamPaper",
                column: "PaperId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacultyCourseStruc_Faculty_FacultyId",
                table: "FacultyCourseStruc",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_SectionCourseStruc_CourseSectionId",
                table: "Grade",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GradePoint_Grade_GradeId",
                table: "GradePoint",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Class_ClassId",
                table: "Quiz",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_UniProject_ProjectId",
                table: "ProjectUser",
                column: "ProjectId",
                principalTable: "UniProject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProjeck_SectionCourseStruc_CourseSectionId",
                table: "ResearchProjeck",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProjeck_Faculty_FacultyId",
                table: "ResearchProjeck",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RProjectPaper_Paper_PaperId",
                table: "RProjectPaper",
                column: "PaperId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RProjectPaper_ResearchProjeck_RProjectId",
                table: "RProjectPaper",
                column: "RProjectId",
                principalTable: "ResearchProjeck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RTopicUser_ResearchTopic_RTopicId",
                table: "RTopicUser",
                column: "RTopicId",
                principalTable: "ResearchTopic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_SemOffering_SemOfferingId",
                table: "Section",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseStruc_CourseSturucture_CourseStrucId",
                table: "SectionCourseStruc",
                column: "CourseStrucId",
                principalTable: "CourseSturucture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseStruc_Section_SectionId",
                table: "SectionCourseStruc",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Semestr_SemOffering_SemOfferingId",
                table: "Semestr",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seminar_Class_ClassId",
                table: "Seminar",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffCourse_Course_CourseId",
                table: "SemOffCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffCourse_SemOffering_SemOfferingId",
                table: "SemOffCourse",
                column: "SemOfferingId",
                principalTable: "SemOffering",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffering_Department_DepartmentId",
                table: "SemOffering",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSchedule_Class_ClassId",
                table: "TimeSchedule",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UniProject_SectionCourseStruc_CourseSectionId",
                table: "UniProject",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UniProject_Faculty_FacultyId",
                table: "UniProject",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExam_Exam_ExamId",
                table: "UserExam",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuiz_Quiz_QuizId",
                table: "UserQuiz",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSectionCourseStruc_SectionCourseStruc_CourseSectionId",
                table: "UserSectionCourseStruc",
                column: "CourseSectionId",
                principalTable: "SectionCourseStruc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSectionCourseStruc_Status_StatusId",
                table: "UserSectionCourseStruc",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
