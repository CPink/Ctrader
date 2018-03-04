using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ctrader.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Features (Name) values ('Feature1')");
            migrationBuilder.Sql("insert into Features (Name) values ('Feature2')");
            migrationBuilder.Sql("insert into Features (Name) values ('Feature3')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Features where Name in ('Feature1', 'Feature2', 'Feature3')");
        }
    }
}
