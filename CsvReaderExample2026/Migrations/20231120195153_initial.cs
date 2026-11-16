using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CsvReaderExample2023.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FirstName", "SecondName" },
                values: new object[,]
                {
                    { "S00002529", "John", "Rodman" },
                    { "S00023092", "Jan", "Kotas" },
                    { "S00046565", "John", "Edwards" },
                    { "S00078018", "Ming-Yang", "Xie" },
                    { "S00113203", "Bryn Paul", "Dunton" },
                    { "S00114203", "Martin", "O�Donnell" },
                    { "S00132212", "Steven", "Thorpe" },
                    { "S00156910", "Luciana", "Ramos" },
                    { "S00170776", "Daniel", "Goldschmidt" },
                    { "S00213687", "Mariya", "Sergienko" },
                    { "S00225481", "Cornelia", "Weiler" },
                    { "S00241057", "Bernard", "Tham" },
                    { "S00274643", "Antonio", "Gratacos Solsona" },
                    { "S00278258", "Anna", "Bedecs" },
                    { "S00287450", "Carlos", "Grilo" },
                    { "S00303021", "Madeleine", "Kelley" },
                    { "S00342403", "Nancy", "Freehafer" },
                    { "S00360626", "Thomas", "Axen" },
                    { "S00360809", "Sven", "Mortensen" },
                    { "S00380454", "Run", "Liu" },
                    { "S00387552", "Soo Jung", "Lee" },
                    { "S00389325", "Michael", "Entin" },
                    { "S00413210", "Michael", "Neipper" },
                    { "S00430473", "Anne", "Hellung-Larsen" },
                    { "S00442638", "Andre", "Ludick" },
                    { "S00449490", "Naoki", "Sato" },
                    { "S00452407", "Francisco", "P�rez-Olaeta" },
                    { "S00472973", "Elizabeth", "Andersen" },
                    { "S00483498", "George", "Li" },
                    { "S00540216", "Christina", "Lee" },
                    { "S00585868", "Elizabeth A.", "Andersen" },
                    { "S00586142", "Amaya", "Hernandez-Echevarria" },
                    { "S00599865", "Roland", "Wacker" },
                    { "S00633249", "Stuart", "Glasson" },
                    { "S00634533", "Karen", "Toh" },
                    { "S00636735", "Jonas", "Hasselberg" },
                    { "S00698845", "Alexander", "Eggerer" },
                    { "S00757976", "Helena", "Kupkova" },
                    { "S00806042", "Catherine", "Autier Miconi" },
                    { "S00838203", "Andrew", "Cencini" },
                    { "S00873144", "Jean Philippe", "Bagel" },
                    { "S00880651", "Satomi", "Hayakawa" },
                    { "S00913453", "Luis", "Sousa" },
                    { "S00932913", "Mikael", "Sandberg" },
                    { "S00947280", "Peter", "Krschne" },
                    { "S00967156", "Robert", "Zare" },
                    { "S00971382", "Amritansh", "Raghav" },
                    { "S00978944", "Laura", "Giussani" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
