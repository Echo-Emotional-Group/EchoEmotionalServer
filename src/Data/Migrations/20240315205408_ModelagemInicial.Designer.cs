﻿// <auto-generated />
using System;
using Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    [DbContext(typeof(DbEchoEmotional))]
    [Migration("20240315205408_ModelagemInicial")]
    partial class ModelagemInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Emocao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("emotion_desc");

                    b.Property<string>("IdPost")
                        .HasColumnType("text")
                        .HasColumnName("id_post");

                    b.HasKey("Id");

                    b.ToTable("emotion");
                });

            modelBuilder.Entity("Models.Reacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Tipo")
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("reaction");
                });

            modelBuilder.Entity("Models.Registro", b =>
                {
                    b.Property<Guid>("IdEmocao")
                        .HasColumnType("serial")
                        .HasColumnName("emotion_id");

                    b.Property<Guid>("idReacao")
                        .HasColumnType("serial")
                        .HasColumnName("reaction_id");

                    b.HasKey("IdEmocao", "idReacao");

                    b.HasIndex("idReacao");

                    b.ToTable("emotion_reaction");
                });

            modelBuilder.Entity("Models.Registro", b =>
                {
                    b.HasOne("Models.Emocao", "Emocao")
                        .WithMany("Registros")
                        .HasForeignKey("IdEmocao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Reacao", "Reacao")
                        .WithMany("Registros")
                        .HasForeignKey("idReacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emocao");

                    b.Navigation("Reacao");
                });

            modelBuilder.Entity("Models.Emocao", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("Models.Reacao", b =>
                {
                    b.Navigation("Registros");
                });
#pragma warning restore 612, 618
        }
    }
}
