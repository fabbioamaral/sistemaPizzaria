using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoDetalhes");

            migrationBuilder.CreateTable(
                name: "PedidoProduto",
                columns: table => new
                {
                    PedidoProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    DescontoNoItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProduto", x => x.PedidoProdutoId);
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_PedidoId",
                table: "PedidoProduto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_ProdutoId",
                table: "PedidoProduto",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProduto");

            migrationBuilder.CreateTable(
                name: "PedidoDetalhes",
                columns: table => new
                {
                    PedidoDetalhesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescontoNoItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoDetalhes", x => x.PedidoDetalhesId);
                    table.ForeignKey(
                        name: "FK_PedidoDetalhes_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoDetalhes_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalhes_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalhes_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId");
        }
    }
}
