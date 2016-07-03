using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20160703045720_ss")]
    partial class ss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.WebApp.JobInfo", b =>
                {
                    b.Property<int>("jobID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("deadline");

                    b.Property<string>("employeer");

                    b.Property<string>("employeerLogo");

                    b.Property<string>("jobDescriptions");

                    b.Property<string>("jobTitle")
                        .IsRequired();

                    b.Property<string>("requirements");

                    b.Property<string>("views");

                    b.HasKey("jobID");

                    b.ToTable("JobInfo");
                });
        }
    }
}
