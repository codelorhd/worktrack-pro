﻿// <auto-generated />
using System;
using JobTrackPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobTrackPro.Migrations
{
    [DbContext(typeof(Model_DataContext))]
    partial class Model_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JobTrackPro.Models.Skill", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("JobTrackPro.Models.User", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("forgot_password_code")
                        .HasColumnType("text");

                    b.Property<bool>("is_enabled")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_legal_status")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("post_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<DateTime>("start_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("verification_code")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobTrackPro.Models.UserSkill", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("skillId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("skillId");

                    b.HasIndex("userId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("JobTrackPro.Models.UserTask", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("task_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("task_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("JobTrackPro.Models.UserSkill", b =>
                {
                    b.HasOne("JobTrackPro.Models.Skill", "skill")
                        .WithMany()
                        .HasForeignKey("skillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobTrackPro.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("skill");

                    b.Navigation("user");
                });

            modelBuilder.Entity("JobTrackPro.Models.UserTask", b =>
                {
                    b.HasOne("JobTrackPro.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
