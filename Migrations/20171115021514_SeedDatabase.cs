using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into makes(name) values ('Make1')");
            migrationBuilder.Sql("insert into makes(name) values ('Make2')");
            migrationBuilder.Sql("insert into makes(name) values ('Make3')");

            migrationBuilder.Sql("insert into models(name, makeid) values ('Make1-ModelA',(select id from makes where name = 'Make1'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make1-ModelB',(select id from makes where name = 'Make1'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make1-ModelC',(select id from makes where name = 'Make1'))");

            migrationBuilder.Sql("insert into models(name, makeid) values ('Make2-ModelA',(select id from makes where name = 'Make2'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make2-ModelB',(select id from makes where name = 'Make2'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make2-ModelC',(select id from makes where name = 'Make2'))");

            migrationBuilder.Sql("insert into models(name, makeid) values ('Make3-ModelA',(select id from makes where name = 'Make3'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make3-ModelB',(select id from makes where name = 'Make3'))");
            migrationBuilder.Sql("insert into models(name, makeid) values ('Make3-ModelC',(select id from makes where name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from makes where name in ('Make1','Make2','Make3')"); 
        }
    }
}
