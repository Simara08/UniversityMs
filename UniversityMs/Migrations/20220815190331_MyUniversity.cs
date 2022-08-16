using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class MyUniversity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgDesctrip",
                table: "Slides",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imagetitle",
                table: "Slides",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Wikilink",
                table: "Rektorlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Rektorlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Rektorlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgTitle",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgDesc",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SvgIcon",
                table: "Partners",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Newstitle",
                table: "Newspages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Newspages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Newspages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WikiLink",
                table: "Mezunlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgTitle",
                table: "Mezunlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgDesc",
                table: "Mezunlar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ViewLink",
                table: "Maps",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Maps",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Graduates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Desctrip",
                table: "Graduates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Graduates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Elmishuralar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Elmishuralar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Aboutpages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Aboutpages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    DateofBirth = table.Column<DateTime>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assigment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    link = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assigment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchTopic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc = table.Column<string>(nullable: true),
                    Mark = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchTopic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statuss = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocArayish",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Datetime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocArayish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocArayish_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocErize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Datetime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocErize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocErize_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssigmentUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    AssigmentId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    Mark = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigmentUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssigmentUser_Assigment_AssigmentId",
                        column: x => x.AssigmentId,
                        principalTable: "Assigment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssigmentUser_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    ClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quiz_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seminar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seminar_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seminar_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassCourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassCourse_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSturucture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LectureNo = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    Attendance = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSturucture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSturucture_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseDep",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    DepId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDep_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseDep_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Depfaculty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    UniProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depfaculty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depfaculty_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Depfaculty_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Depfaculty_Program_UniProgramId",
                        column: x => x.UniProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(nullable: false),
                    DepId = table.Column<int>(nullable: false),
                    UniProgramId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepUser_Department_DepId",
                        column: x => x.DepId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepUser_Program_UniProgramId",
                        column: x => x.UniProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SemOffering",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    UniProgramId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemOffering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SemOffering_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemOffering_Program_UniProgramId",
                        column: x => x.UniProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RTopicUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTopicId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTopicUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTopicUser_ResearchTopic_RTopicId",
                        column: x => x.RTopicId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RTopicUser_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseTopic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseTopic_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTopic_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamPaper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false),
                    PaperId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamPaper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamPaper_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamPaper_Paper_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Paper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserExam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(nullable: false),
                    ExamId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserExam_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExam_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserQuiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuiz_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuiz_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    SemOfferingId = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_SemOffering_SemOfferingId",
                        column: x => x.SemOfferingId,
                        principalTable: "SemOffering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semestr",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemestrNum = table.Column<int>(nullable: false),
                    SemOfferingId = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Semestr_SemOffering_SemOfferingId",
                        column: x => x.SemOfferingId,
                        principalTable: "SemOffering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemOffCourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemOfferingId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemOffCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SemOffCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemOffCourse_SemOffering_SemOfferingId",
                        column: x => x.SemOfferingId,
                        principalTable: "SemOffering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionCourseStruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseStrucId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionCourseStruc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionCourseStruc_CourseSturucture_CourseStrucId",
                        column: x => x.CourseStrucId,
                        principalTable: "CourseSturucture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionCourseStruc_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssigmentCourseSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssigmentId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false),
                    SectionCourseStrucId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigmentCourseSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssigmentCourseSection_Assigment_AssigmentId",
                        column: x => x.AssigmentId,
                        principalTable: "Assigment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssigmentCourseSection_SectionCourseStruc_SectionCourseStrucId",
                        column: x => x.SectionCourseStrucId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseQuiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseSectionId = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    SectionCourseStrucId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseQuiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseQuiz_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseQuiz_SectionCourseStruc_SectionCourseStrucId",
                        column: x => x.SectionCourseStrucId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamCourseStruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false),
                    SectionCourseStrucId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCourseStruc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamCourseStruc_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamCourseStruc_SectionCourseStruc_SectionCourseStrucId",
                        column: x => x.SectionCourseStrucId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacultyCourseStruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false),
                    SectionCourseStrucId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyCourseStruc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacultyCourseStruc_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacultyCourseStruc_SectionCourseStruc_SectionCourseStrucId",
                        column: x => x.SectionCourseStrucId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_SectionCourseStruc_CourseSectionId",
                        column: x => x.CourseSectionId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grade_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResearchProjeck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMark = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchProjeck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchProjeck_SectionCourseStruc_CourseSectionId",
                        column: x => x.CourseSectionId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchProjeck_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starttime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Day = table.Column<string>(nullable: true),
                    ClassId = table.Column<int>(nullable: false),
                    CourseSection = table.Column<int>(nullable: false),
                    IsDaleted = table.Column<bool>(nullable: false),
                    SectionCourseStrucId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSchedule_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeSchedule_SectionCourseStruc_SectionCourseStrucId",
                        column: x => x.SectionCourseStrucId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UniProject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMark = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniProject_SectionCourseStruc_CourseSectionId",
                        column: x => x.CourseSectionId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniProject_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSectionCourseStruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CourseSectionId = table.Column<int>(nullable: false),
                    Attendance = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSectionCourseStruc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSectionCourseStruc_SectionCourseStruc_CourseSectionId",
                        column: x => x.CourseSectionId,
                        principalTable: "SectionCourseStruc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSectionCourseStruc_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSectionCourseStruc_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradePoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeId = table.Column<int>(nullable: false),
                    GradePoints = table.Column<string>(nullable: true),
                    IsDaleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradePoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradePoint_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RProjectPaper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaperId = table.Column<int>(nullable: false),
                    RProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RProjectPaper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RProjectPaper_Paper_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Paper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RProjectPaper_ResearchProjeck_RProjectId",
                        column: x => x.RProjectId,
                        principalTable: "ResearchProjeck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RProjectUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RProjectId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    ResearchProjeckId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RProjectUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RProjectUser_ResearchProjeck_ResearchProjeckId",
                        column: x => x.ResearchProjeckId,
                        principalTable: "ResearchProjeck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RProjectUser_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectUser_UniProject_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "UniProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentCourseSection_AssigmentId",
                table: "AssigmentCourseSection",
                column: "AssigmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentCourseSection_SectionCourseStrucId",
                table: "AssigmentCourseSection",
                column: "SectionCourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentUser_AssigmentId",
                table: "AssigmentUser",
                column: "AssigmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentUser_UserId1",
                table: "AssigmentUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse_ClassId",
                table: "ClassCourse",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse_CourseId",
                table: "ClassCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDep_CourseId",
                table: "CourseDep",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDep_DepartmentId",
                table: "CourseDep",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseQuiz_QuizId",
                table: "CourseQuiz",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseQuiz_SectionCourseStrucId",
                table: "CourseQuiz",
                column: "SectionCourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSturucture_CourseId",
                table: "CourseSturucture",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseTopic_CourseId",
                table: "CourseTopic",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTopic_TopicId",
                table: "CourseTopic",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Depfaculty_DepartmentId",
                table: "Depfaculty",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Depfaculty_FacultyId",
                table: "Depfaculty",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Depfaculty_UniProgramId",
                table: "Depfaculty",
                column: "UniProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_DepUser_DepId",
                table: "DepUser",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_DepUser_UniProgramId",
                table: "DepUser",
                column: "UniProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_DepUser_UserId",
                table: "DepUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DocArayish_UserId",
                table: "DocArayish",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DocErize_UserId",
                table: "DocErize",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ClassId",
                table: "Exam",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCourseStruc_ExamId",
                table: "ExamCourseStruc",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCourseStruc_SectionCourseStrucId",
                table: "ExamCourseStruc",
                column: "SectionCourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamPaper_ExamId",
                table: "ExamPaper",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamPaper_PaperId",
                table: "ExamPaper",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultyCourseStruc_FacultyId",
                table: "FacultyCourseStruc",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultyCourseStruc_SectionCourseStrucId",
                table: "FacultyCourseStruc",
                column: "SectionCourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_CourseSectionId",
                table: "Grade",
                column: "CourseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_UserId1",
                table: "Grade",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_GradePoint_GradeId",
                table: "GradePoint",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_ClassId",
                table: "Quiz",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId1",
                table: "ProjectUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchProjeck_CourseSectionId",
                table: "ResearchProjeck",
                column: "CourseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchProjeck_FacultyId",
                table: "ResearchProjeck",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_RProjectPaper_PaperId",
                table: "RProjectPaper",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_RProjectPaper_RProjectId",
                table: "RProjectPaper",
                column: "RProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_RProjectUser_ResearchProjeckId",
                table: "RProjectUser",
                column: "ResearchProjeckId");

            migrationBuilder.CreateIndex(
                name: "IX_RProjectUser_UserId1",
                table: "RProjectUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RTopicUser_RTopicId",
                table: "RTopicUser",
                column: "RTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_RTopicUser_UserId1",
                table: "RTopicUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Section_SemOfferingId",
                table: "Section",
                column: "SemOfferingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SectionCourseStruc_CourseStrucId",
                table: "SectionCourseStruc",
                column: "CourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCourseStruc_SectionId",
                table: "SectionCourseStruc",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Semestr_SemOfferingId",
                table: "Semestr",
                column: "SemOfferingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seminar_ClassId",
                table: "Seminar",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Seminar_UserId1",
                table: "Seminar",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_SemOffCourse_CourseId",
                table: "SemOffCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SemOffCourse_SemOfferingId",
                table: "SemOffCourse",
                column: "SemOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_SemOffering_DepartmentId",
                table: "SemOffering",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SemOffering_UniProgramId",
                table: "SemOffering",
                column: "UniProgramId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSchedule_ClassId",
                table: "TimeSchedule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSchedule_SectionCourseStrucId",
                table: "TimeSchedule",
                column: "SectionCourseStrucId");

            migrationBuilder.CreateIndex(
                name: "IX_UniProject_CourseSectionId",
                table: "UniProject",
                column: "CourseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UniProject_FacultyId",
                table: "UniProject",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExam_ExamId",
                table: "UserExam",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExam_UserId",
                table: "UserExam",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuiz_QuizId",
                table: "UserQuiz",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuiz_UserId1",
                table: "UserQuiz",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserSectionCourseStruc_CourseSectionId",
                table: "UserSectionCourseStruc",
                column: "CourseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSectionCourseStruc_StatusId",
                table: "UserSectionCourseStruc",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSectionCourseStruc_UserId1",
                table: "UserSectionCourseStruc",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssigmentCourseSection");

            migrationBuilder.DropTable(
                name: "AssigmentUser");

            migrationBuilder.DropTable(
                name: "ClassCourse");

            migrationBuilder.DropTable(
                name: "CourseDep");

            migrationBuilder.DropTable(
                name: "CourseQuiz");

            migrationBuilder.DropTable(
                name: "CourseTopic");

            migrationBuilder.DropTable(
                name: "Depfaculty");

            migrationBuilder.DropTable(
                name: "DepUser");

            migrationBuilder.DropTable(
                name: "DocArayish");

            migrationBuilder.DropTable(
                name: "DocErize");

            migrationBuilder.DropTable(
                name: "ExamCourseStruc");

            migrationBuilder.DropTable(
                name: "ExamPaper");

            migrationBuilder.DropTable(
                name: "FacultyCourseStruc");

            migrationBuilder.DropTable(
                name: "GradePoint");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "RProjectPaper");

            migrationBuilder.DropTable(
                name: "RProjectUser");

            migrationBuilder.DropTable(
                name: "RTopicUser");

            migrationBuilder.DropTable(
                name: "Semestr");

            migrationBuilder.DropTable(
                name: "Seminar");

            migrationBuilder.DropTable(
                name: "SemOffCourse");

            migrationBuilder.DropTable(
                name: "TimeSchedule");

            migrationBuilder.DropTable(
                name: "UserExam");

            migrationBuilder.DropTable(
                name: "UserQuiz");

            migrationBuilder.DropTable(
                name: "UserSectionCourseStruc");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Assigment");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "UniProject");

            migrationBuilder.DropTable(
                name: "Paper");

            migrationBuilder.DropTable(
                name: "ResearchProjeck");

            migrationBuilder.DropTable(
                name: "ResearchTopic");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SectionCourseStruc");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "CourseSturucture");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "SemOffering");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.AlterColumn<string>(
                name: "ImgDesctrip",
                table: "Slides",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Imagetitle",
                table: "Slides",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Wikilink",
                table: "Rektorlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Rektorlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Rektorlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImgTitle",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImgDesc",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SvgIcon",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Newstitle",
                table: "Newspages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Newspages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Newspages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "WikiLink",
                table: "Mezunlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImgTitle",
                table: "Mezunlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImgDesc",
                table: "Mezunlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ViewLink",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Graduates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Desctrip",
                table: "Graduates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Graduates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Elmishuralar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Elmishuralar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Aboutpages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Aboutpages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
