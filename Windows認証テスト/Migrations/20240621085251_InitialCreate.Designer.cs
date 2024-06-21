﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Windows認証テスト.DB;

#nullable disable

namespace Windows認証テスト.Migrations
{
    [DbContext(typeof(TestDBContext))]
    [Migration("20240621085251_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Windows認証テスト.Model.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text")
                        .HasColumnName("user_id")
                        .HasComment("ユーザーID");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("role")
                        .HasComment("権限コード");

                    b.HasKey("UserId");

                    b.ToTable("users", t =>
                        {
                            t.HasComment("ログイン管理用");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
