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
    [Migration("20240315073015_ColoqueiIdPerfilUserObrigatorio")]
    partial class ColoqueiIdPerfilUserObrigatorio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Emotion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Emotion_Desc")
                        .HasColumnType("text");

                    b.Property<string>("Id_Post")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id_Post");

                    b.ToTable("Emotions");
                });

            modelBuilder.Entity("Models.Perfil_User", b =>
                {
                    b.Property<string>("Id_accont_facebook")
                        .HasColumnType("text");

                    b.Property<DateTime>("Data_Nasc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Data_Post")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Data_Registro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Full_Name")
                        .HasColumnType("text");

                    b.HasKey("Id_accont_facebook");

                    b.ToTable("Perfil_users");
                });

            modelBuilder.Entity("Models.Emotion", b =>
                {
                    b.HasOne("Models.Perfil_User", "Perfil_User")
                        .WithMany("Emotions")
                        .HasForeignKey("Id_Post");

                    b.Navigation("Perfil_User");
                });

            modelBuilder.Entity("Models.Perfil_User", b =>
                {
                    b.Navigation("Emotions");
                });
#pragma warning restore 612, 618
        }
    }
}
