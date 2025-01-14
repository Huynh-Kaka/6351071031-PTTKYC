using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BTL_WINFORM.Models.Entities
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public virtual DbSet<Account> Account{ get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("Data Source=LAPTOP-F66NR7HC;Initial Catalog=quanCoffe;Integrated Security=True;Trust Server Certificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountID).HasName("PK_Account");

                entity.ToTable("Accounts");

                entity.Property(e => e.Username).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Password).HasMaxLength(256).IsRequired();

                entity.Property(e => e.Role)
               .IsRequired()
               .HasDefaultValue(2); // Mặc định là nhân viên (Role = 2)

                // Kiểm tra giá trị của Role
                entity.HasCheckConstraint("CK_Account_Role", "Role IN (1, 2)");
            });


            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID).HasName("PK_Customer");

                entity.ToTable("Customers");

                entity.Property(e => e.FullName).HasMaxLength(100).IsRequired();// sua 
                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryID).HasName("PK_Category");

                entity.ToTable("Categories");

                entity.Property(e => e.CategoryName).HasMaxLength(100).IsRequired();
            });

            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.HasKey(e => e.ProductID).HasName("PK_Product");

            //    entity.ToTable("Products");

            //    entity.Property(e => e.ProductName).HasMaxLength(100).IsRequired();
            //    entity.Property(e => e.Price).HasColumnType("decimal(10, 2)").IsRequired();
            //    entity.Property(e => e.Description).HasColumnType("text");
            //    entity.Property(e => e.Image).HasMaxLength(255);

            //    entity.HasOne(d => d.Category)
            //          .WithMany(p => p.Products)
            //          .HasForeignKey(d => d.CategoryID)
            //          .OnDelete(DeleteBehavior.Cascade)
            //          .HasConstraintName("FK_Product_Category");
            //});

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductID).HasName("PK_Product");

                entity.ToTable("Products");

                entity.Property(e => e.ProductName)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.CategoryID)
                      .IsRequired();

                entity.Property(e => e.Price)
                      .HasColumnType("decimal(10, 2)")
                      .IsRequired();

                //entity.Property(e => e.Quantity)
                //      .HasDefaultValue(0); // Adding Quantity with a default value

                //entity.Property(e => e.Description)
                //      .HasColumnType("text");

                entity.Property(e => e.Image)
                      .HasMaxLength(255);

                entity.HasOne(d => d.Category)
                      .WithMany(p => p.Products)
                      .HasForeignKey(d => d.CategoryID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_Product_Category");
            });


            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.TableID).HasName("PK_Table");

                entity.ToTable("Tables");

                entity.Property(e => e.TableName).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Capacity).HasColumnType("int");
                entity.Property(e => e.Status).HasDefaultValue(true);// 1: Trống, 0: Đã đặt
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID).HasName("PK_Order");

                entity.ToTable("Orders");

                entity.Property(e => e.OrderDate).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");

                entity.HasOne(d => d.Customer)
                      .WithMany(p => p.Orders)
                      .HasForeignKey(d => d.CustomerID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Account)
                      .WithMany(p => p.Orders)
                      .HasForeignKey(d => d.AccountID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Order_Account");

                entity.HasOne(d => d.Table)
                      .WithMany(p => p.Orders)
                      .HasForeignKey(d => d.TableID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Order_Table");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailID).HasName("PK_OrderDetail");

                entity.ToTable("OrderDetails");

                entity.Property(e => e.Quantity).HasDefaultValue(1);

                entity.HasOne(d => d.Order)
                      .WithMany(p => p.OrderDetails)
                      .HasForeignKey(d => d.OrderID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                      .WithMany(p => p.OrderDetails)
                      .HasForeignKey(d => d.ProductID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceID).HasName("PK_Invoice");

                entity.ToTable("Invoices");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)").IsRequired();

                entity.HasOne(d => d.Order)
                      .WithMany(p => p.Invoices)
                      .HasForeignKey(d => d.OrderID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_Invoice_Order");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailID).HasName("PK_InvoiceDetail");

                entity.ToTable("InvoiceDetails");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)").IsRequired();
                entity.Property(e => e.TotalPrice).HasComputedColumnSql("[Quantity] * [UnitPrice]");

                entity.HasOne(d => d.Invoice)
                      .WithMany(p => p.InvoiceDetails)
                      .HasForeignKey(d => d.InvoiceID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_InvoiceDetail_Invoice");

                entity.HasOne(d => d.Product)
                      .WithMany(p => p.InvoiceDetails)
                      .HasForeignKey(d => d.ProductID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_InvoiceDetail_Product");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeID).HasName("PK_Employee");

                entity.ToTable("Employees");

                entity.Property(e => e.FullName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Position).HasMaxLength(50);
                entity.Property(e => e.DateOfJoining).IsRequired();
                entity.Property(e => e.Status).HasMaxLength(20).HasDefaultValue("Active");
                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("GETDATE()");

                entity.HasOne(d => d.Account)
                      .WithMany(p => p.Employees)
                      .HasForeignKey(d => d.AccountID)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_Employee_Account");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Voucher");

                entity.ToTable("Voucher");

                entity.Property(e => e.MaVoucher).HasMaxLength(50).IsRequired();
                entity.Property(e => e.LoaiGiamGia).HasMaxLength(1).IsRequired();
                entity.Property(e => e.GiaTriGiam).HasColumnType("decimal(10, 2)").IsRequired();
                entity.Property(e => e.NgayBatDau).HasColumnType("date").IsRequired();
                entity.Property(e => e.NgayHetHan).HasColumnType("date").IsRequired();
                entity.Property(e => e.SoLanToiDaSuDung).HasColumnType("int").IsRequired();
                entity.Property(e => e.SoLanDaSuDung).HasColumnType("int").HasDefaultValue(0);
                entity.Property(e => e.GiaTriDonHangToiThieu).HasColumnType("decimal(10, 2)");
                entity.Property(e => e.TrangThai).HasDefaultValue(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
