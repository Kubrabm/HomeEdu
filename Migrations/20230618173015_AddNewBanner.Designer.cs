﻿// <auto-generated />
using System;
using HomeEdu.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeEdu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230618173015_AddNewBanner")]
    partial class AddNewBanner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HomeEdu.DAL.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BgImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.AboutBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("AboutBanner");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Alert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SubscribeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubscribeId");

                    b.ToTable("Alert");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LatestPostId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LatestPostId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Categorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DetailSidebarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DetailSidebarId");

                    b.ToTable("Categori");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.DetailSidebar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("DetailSidebar");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Footer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Copyright")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Footer");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.GetInTouch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("GetInTouch");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Header", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Header");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.HeaderTop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HeaderTop");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("Informations");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.LatestPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("DetailSidebarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DetailSidebarId");

                    b.ToTable("LatestPost");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Navigation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isMain")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HeaderId");

                    b.ToTable("Navigation");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.NavigationTop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HeaderTopId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeaderTopId");

                    b.ToTable("NavigationTop");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.NoticeLeft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoticeLeft");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.NoticeRight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("NoticeRight");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.PageCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PageIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PageCount");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackgroundUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Subscribe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscribe");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DetailSidebarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetailSidebarId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Facebook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pinterest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Testimonial");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.ThemeBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DetailSidebarId")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetailSidebarId");

                    b.ToTable("ThemeBanner");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.UsefulLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FlagUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("UsefulLink");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.AboutBanner", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.About", null)
                        .WithMany("AboutBanners")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Alert", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Subscribe", "Subscribe")
                        .WithMany("Alerts")
                        .HasForeignKey("SubscribeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscribe");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Blog", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.LatestPost", null)
                        .WithMany("Blogs")
                        .HasForeignKey("LatestPostId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Categorie", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.DetailSidebar", "DetailSidebar")
                        .WithMany("Categories")
                        .HasForeignKey("DetailSidebarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailSidebar");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.GetInTouch", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Footer", "Footer")
                        .WithMany("GetInTouches")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Information", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Footer", "Footer")
                        .WithMany("Informations")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.LatestPost", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.DetailSidebar", "DetailSidebar")
                        .WithMany("letstPosts")
                        .HasForeignKey("DetailSidebarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailSidebar");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Navigation", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Header", "Header")
                        .WithMany("Navigations")
                        .HasForeignKey("HeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Header");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.NavigationTop", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.HeaderTop", "HeaderTop")
                        .WithMany("TopNavigation")
                        .HasForeignKey("HeaderTopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeaderTop");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.NoticeRight", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.About", null)
                        .WithMany("NoticeRights")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.SocialMedia", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Footer", "Footer")
                        .WithMany("SosialMedias")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Tag", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.DetailSidebar", "DetailSidebar")
                        .WithMany("Tags")
                        .HasForeignKey("DetailSidebarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailSidebar");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Teacher", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.About", null)
                        .WithMany("Teachers")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Testimonial", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.About", null)
                        .WithMany("Testimonials")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.ThemeBanner", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.DetailSidebar", "DetailSidebar")
                        .WithMany("ThemeBanner")
                        .HasForeignKey("DetailSidebarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailSidebar");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.UsefulLink", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.Footer", "Footer")
                        .WithMany("usefulLinks")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Video", b =>
                {
                    b.HasOne("HomeEdu.DAL.Entities.About", null)
                        .WithMany("Videos")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.About", b =>
                {
                    b.Navigation("AboutBanners");

                    b.Navigation("NoticeRights");

                    b.Navigation("Teachers");

                    b.Navigation("Testimonials");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.DetailSidebar", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Tags");

                    b.Navigation("ThemeBanner");

                    b.Navigation("letstPosts");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Footer", b =>
                {
                    b.Navigation("GetInTouches");

                    b.Navigation("Informations");

                    b.Navigation("SosialMedias");

                    b.Navigation("usefulLinks");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Header", b =>
                {
                    b.Navigation("Navigations");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.HeaderTop", b =>
                {
                    b.Navigation("TopNavigation");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.LatestPost", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("HomeEdu.DAL.Entities.Subscribe", b =>
                {
                    b.Navigation("Alerts");
                });
#pragma warning restore 612, 618
        }
    }
}
