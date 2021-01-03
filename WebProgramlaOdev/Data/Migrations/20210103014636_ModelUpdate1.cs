using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlaOdev.Data.Migrations
{
    public partial class ModelUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hayvan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    IlanTarihi = table.Column<DateTime>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false),
                    TelNo = table.Column<int>(nullable: false),
                    Il = table.Column<string>(nullable: true),
                    Ilce = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UKategori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kedi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cins = table.Column<string>(nullable: true),
                    HayvanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kedi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kedi_Hayvan_HayvanId",
                        column: x => x.HayvanId,
                        principalTable: "Hayvan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kopek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cins = table.Column<string>(nullable: true),
                    HayvanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kopek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kopek_Hayvan_HayvanId",
                        column: x => x.HayvanId,
                        principalTable: "Hayvan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Acıklama = table.Column<string>(nullable: true),
                    Ucret = table.Column<bool>(nullable: false),
                    UKategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urun_UKategori_UKategoriId",
                        column: x => x.UKategoriId,
                        principalTable: "UKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorumlar = table.Column<string>(nullable: true),
                    YorumTarihi = table.Column<DateTime>(nullable: false),
                    UrunId = table.Column<int>(nullable: false),
                    UyeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorum_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorum_Uye_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uye",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kedi_HayvanId",
                table: "Kedi",
                column: "HayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kopek_HayvanId",
                table: "Kopek",
                column: "HayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_UKategoriId",
                table: "Urun",
                column: "UKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UrunId",
                table: "Yorum",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UyeId",
                table: "Yorum",
                column: "UyeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kedi");

            migrationBuilder.DropTable(
                name: "Kopek");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Hayvan");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Uye");

            migrationBuilder.DropTable(
                name: "UKategori");
        }
    }
}
