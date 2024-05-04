﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RustStashServer.Core;

#nullable disable

namespace RustStashServer.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240504114428_ChangedTableAttribute231234567io3456")]
    partial class ChangedTableAttribute231234567io3456
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("TotalItemsCrafted")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Base", b =>
                {
                    b.Property<int>("BaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BaseId"));

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BaseId");

                    b.ToTable("Bases");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MaterialId"));

                    b.Property<string>("MaterialDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaterialImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("MaterialIsCraftable")
                        .HasColumnType("boolean");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.MaterialCategory", b =>
                {
                    b.Property<int>("MaterialIds")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryIds")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.HasKey("MaterialIds", "CategoryIds");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryIds");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialCategory");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RecipeId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecipeImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RequiredBenchLevel")
                        .HasColumnType("integer");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.RecipeMaterial", b =>
                {
                    b.Property<int>("RecipeIds")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialIds")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.HasKey("RecipeIds", "MaterialIds");

                    b.HasIndex("MaterialId");

                    b.HasIndex("MaterialIds");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.StashItemType", b =>
                {
                    b.Property<int>("StashItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StashItemTypeId"));

                    b.Property<string>("StashItemTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StashItemTypeId");

                    b.ToTable("StashItemType");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.UserStash", b =>
                {
                    b.Property<int>("UserStashId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<int>("StashItemTypeId")
                        .HasColumnType("integer");

                    b.HasKey("UserStashId");

                    b.HasIndex("StashItemTypeId");

                    b.ToTable("UserStashes");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.UserStashMaterial", b =>
                {
                    b.Property<int>("UserStashIds")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialIds")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.Property<int>("UserStashId")
                        .HasColumnType("integer");

                    b.Property<int>("UserStashMaterialOwnerId")
                        .HasColumnType("integer");

                    b.HasKey("UserStashIds", "MaterialIds");

                    b.HasIndex("MaterialId");

                    b.HasIndex("MaterialIds");

                    b.HasIndex("UserStashId");

                    b.HasIndex("UserStashMaterialOwnerId");

                    b.ToTable("UserStashMaterials");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.MaterialCategory", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Category", null)
                        .WithMany("MaterialCategories")
                        .HasForeignKey("CategoryIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Material", null)
                        .WithMany("MaterialCategories")
                        .HasForeignKey("MaterialIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Recipe", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.RecipeMaterial", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Material", null)
                        .WithMany("RecipeMaterials")
                        .HasForeignKey("MaterialIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Recipe", null)
                        .WithMany("RecipeMaterials")
                        .HasForeignKey("RecipeIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.UserStash", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.StashItemType", "StashItemType")
                        .WithMany()
                        .HasForeignKey("StashItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Base", "Base")
                        .WithOne("BaseUserStashId")
                        .HasForeignKey("RustStashServer.Core.Entities.UserStash", "UserStashId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Base");

                    b.Navigation("StashItemType");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.UserStashMaterial", b =>
                {
                    b.HasOne("RustStashServer.Core.Entities.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Material", null)
                        .WithMany("UserStashMaterials")
                        .HasForeignKey("MaterialIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.UserStash", "UserStash")
                        .WithMany()
                        .HasForeignKey("UserStashId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.UserStash", null)
                        .WithMany("UserStashMaterials")
                        .HasForeignKey("UserStashIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RustStashServer.Core.Entities.Auth.User", "UserStashMaterialOwner")
                        .WithMany("UserStashMaterials")
                        .HasForeignKey("UserStashMaterialOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("UserStash");

                    b.Navigation("UserStashMaterialOwner");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Auth.User", b =>
                {
                    b.Navigation("UserStashMaterials");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Base", b =>
                {
                    b.Navigation("BaseUserStashId")
                        .IsRequired();
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Category", b =>
                {
                    b.Navigation("MaterialCategories");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Material", b =>
                {
                    b.Navigation("MaterialCategories");

                    b.Navigation("RecipeMaterials");

                    b.Navigation("UserStashMaterials");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeMaterials");
                });

            modelBuilder.Entity("RustStashServer.Core.Entities.UserStash", b =>
                {
                    b.Navigation("UserStashMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}