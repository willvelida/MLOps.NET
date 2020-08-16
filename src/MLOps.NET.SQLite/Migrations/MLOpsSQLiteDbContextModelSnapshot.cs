﻿// <auto-generated />
using System;
using MLOps.NET.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MLOps.NET.SQLite.Migrations
{
    [DbContext(typeof(MLOpsSQLiteDbContext))]
    partial class MLOpsSQLiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("MLOps.NET.Entities.Impl.ConfusionMatrixEntity", b =>
                {
                    b.Property<Guid>("ConfusionMatrixEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedMatrix")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ConfusionMatrixEntityId");

                    b.HasIndex("RunId")
                        .IsUnique();

                    b.ToTable("ConfusionMatrix");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Data", b =>
                {
                    b.Property<Guid>("DataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataHash")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.HasKey("DataId");

                    b.ToTable("Data");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataColumn", b =>
                {
                    b.Property<Guid>("DataColumnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DataSchemaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("DataColumnId");

                    b.HasIndex("DataSchemaId");

                    b.ToTable("DataColumn");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataDistribution", b =>
                {
                    b.Property<Guid>("DataDistributionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("DataColumnId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DataDistributionId");

                    b.HasIndex("DataColumnId");

                    b.ToTable("DataDistribution");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataSchema", b =>
                {
                    b.Property<Guid>("DataSchemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ColumnCount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("DataId")
                        .HasColumnType("TEXT");

                    b.HasKey("DataSchemaId");

                    b.HasIndex("DataId")
                        .IsUnique();

                    b.ToTable("DataSchema");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Deployment", b =>
                {
                    b.Property<Guid>("DeploymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeployedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DeploymentDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DeploymentTargetId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeploymentUri")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RegisteredModelId")
                        .HasColumnType("TEXT");

                    b.HasKey("DeploymentId");

                    b.HasIndex("DeploymentTargetId");

                    b.HasIndex("RegisteredModelId");

                    b.ToTable("Deployment");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DeploymentTarget", b =>
                {
                    b.Property<Guid>("DeploymentTargetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsProduction")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeploymentTargetId");

                    b.ToTable("DeploymentTarget");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Experiment", b =>
                {
                    b.Property<Guid>("ExperimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExperimentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ExperimentId");

                    b.ToTable("Experiment");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.HyperParameter", b =>
                {
                    b.Property<Guid>("HyperParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParameterName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HyperParameterId");

                    b.HasIndex("RunId");

                    b.ToTable("HyperParameter");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Metric", b =>
                {
                    b.Property<Guid>("MetricId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("MetricName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("MetricId");

                    b.HasIndex("RunId");

                    b.ToTable("Metric");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.RegisteredModel", b =>
                {
                    b.Property<Guid>("RegisteredModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ExperimentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegisteredBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunArtifactId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("RegisteredModelId");

                    b.ToTable("RegisteredModel");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Run", b =>
                {
                    b.Property<Guid>("RunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ExperimentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GitCommitHash")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RunDate")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("TrainingTime")
                        .HasColumnType("TEXT");

                    b.HasKey("RunId");

                    b.HasIndex("ExperimentId");

                    b.ToTable("Run");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.RunArtifact", b =>
                {
                    b.Property<Guid>("RunArtifactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RunId")
                        .HasColumnType("TEXT");

                    b.HasKey("RunArtifactId");

                    b.HasIndex("RunId");

                    b.ToTable("RunArtifact");
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.ConfusionMatrixEntity", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Run", null)
                        .WithOne("ConfusionMatrix")
                        .HasForeignKey("MLOps.NET.Entities.Impl.ConfusionMatrixEntity", "RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataColumn", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.DataSchema", null)
                        .WithMany("DataColumns")
                        .HasForeignKey("DataSchemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataDistribution", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.DataColumn", null)
                        .WithMany("DataDistributions")
                        .HasForeignKey("DataColumnId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.DataSchema", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Data", null)
                        .WithOne("DataSchema")
                        .HasForeignKey("MLOps.NET.Entities.Impl.DataSchema", "DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Deployment", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.DeploymentTarget", null)
                        .WithMany("Deployments")
                        .HasForeignKey("DeploymentTargetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MLOps.NET.Entities.Impl.RegisteredModel", null)
                        .WithMany("Deployments")
                        .HasForeignKey("RegisteredModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.HyperParameter", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Run", null)
                        .WithMany("HyperParameters")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Metric", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Run", null)
                        .WithMany("Metrics")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.Run", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Experiment", null)
                        .WithMany("Runs")
                        .HasForeignKey("ExperimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MLOps.NET.Entities.Impl.RunArtifact", b =>
                {
                    b.HasOne("MLOps.NET.Entities.Impl.Run", null)
                        .WithMany("RunArtifacts")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
