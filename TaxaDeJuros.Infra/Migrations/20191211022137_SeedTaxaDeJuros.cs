using System;
using Microsoft.EntityFrameworkCore.Migrations;
using TaxaDeJuros.Infra.CrossCutting;

namespace TaxaDeJuros.Infra.Migrations
{
    public partial class SeedTaxaDeJuros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxaDeJuros",
                columns: new[] { "Valor" },
                values: new Object[] {TaxaDeJurosConstants.ValorDaTaxaDeJuros});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}