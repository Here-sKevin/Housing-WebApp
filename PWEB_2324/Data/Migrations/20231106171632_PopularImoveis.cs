using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace PWEB_2324.Data.Migrations
{
    public partial class PopularImoveis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T1','T1 a vender', 1, 'T1', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2015', '05/29/2016', 10, 'A')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
            migrationBuilder.Sql("INSERT INTO Imovel(Title, Description, Func_Id, Type, Price, Image, Location, Property, Wc, Date_init, Data_end, Min_Time, Energy) " +
                "VALUES('T2','T2 a vender', 1, 'T2', 100, 'teste', 'porto', 'apartamento', 2, '05/29/2016', '05/29/2017', 10, 'B')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Imovel");
        }
    }
}
