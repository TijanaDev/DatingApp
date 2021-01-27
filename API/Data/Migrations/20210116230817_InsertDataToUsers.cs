using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InsertDataToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         /*   migrationBuilder.Sql(
                "INSERT INTO Users VALUES('Tijana')"
            );
                 migrationBuilder.Sql(
                "INSERT INTO Users VALUES('Aca')"
                
            );

             migrationBuilder.Sql(
                "INSERT INTO Users VALUES('Vanja')"
                
            );*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.Sql(
                "DELETE FROM Users"
            );*/
        }
    }
}
