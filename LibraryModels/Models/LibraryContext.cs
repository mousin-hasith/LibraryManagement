using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManagement.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Reader> Readers { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<staff> Staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0J0TDPA;Initial Catalog=Library;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("AUTHOR");

                entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .HasColumnName("AUTHOR_NAME");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("BOOKS");

                entity.Property(e => e.BookId).HasColumnName("BOOK_ID");

                entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");

                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .HasColumnName("BOOK_NAME");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.IsbnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISBN_NO");

                entity.Property(e => e.PublisherId).HasColumnName("PUBLISHER_ID");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__BOOKS__AUTHOR_ID__2E1BDC42");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("FK__BOOKS__CATEGORYI__2F10007B");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK__BOOKS__PUBLISHER__300424B4");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("CATEGORY_NAME");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("PUBLISHER");

                entity.Property(e => e.PublisherId).HasColumnName("PUBLISHER_ID");

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(50)
                    .HasColumnName("PUBLISHER_NAME");

                entity.Property(e => e.YearOfPublication).HasColumnName("YEAR_OF_PUBLICATION");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.ToTable("READERS");

                entity.Property(e => e.ReaderId).HasColumnName("READER_ID");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_NO");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("REPORTS");

                entity.Property(e => e.ReportId).HasColumnName("REPORT_ID");

                entity.Property(e => e.BookId).HasColumnName("BOOK_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISSUE_DATE");

                entity.Property(e => e.ReaderId).HasColumnName("READER_ID");

                entity.Property(e => e.Returndate)
                    .HasColumnType("datetime")
                    .HasColumnName("RETURNDATE");

                entity.Property(e => e.StaffId).HasColumnName("STAFF_ID");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__REPORTS__BOOK_ID__46E78A0C");

                entity.HasOne(d => d.Reader)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReaderId)
                    .HasConstraintName("FK__REPORTS__READER___47DBAE45");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__REPORTS__STAFF_I__48CFD27E");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__REPORTS__STATUS___49C3F6B7");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("STATUS");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.Status1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("STAFF");

                entity.Property(e => e.StaffId).HasColumnName("STAFF_ID");

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .HasColumnName("STAFF_NAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
