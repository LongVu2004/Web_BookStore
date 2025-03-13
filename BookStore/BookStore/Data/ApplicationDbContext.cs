using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed dữ liệu cho bảng Books
            modelBuilder.Entity<Book>().HasData(
                new Book { BookID = 1, Title = "Sách 1", Author = "Tác giả A", Description = "Sách học lập trình", Price = 100, ImageUrl = "C:\\Users\\phaml\\image_hieusach\\Sach\\dac-nhan-tam", StockQuantity = 10, CategoryID = 1 },
                new Book { BookID = 2, Title = "Sách 2", Author = "Tác giả B", Description = "Truyện thiếu nhi", Price = 200, ImageUrl = "C:\\Users\\phaml\\image_hieusach\\Sach\\dac-nhan-tam", StockQuantity = 5, CategoryID = 2 }
            );

            // Seed dữ liệu cho bảng Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Lập trình" },
                new Category { CategoryID = 2, CategoryName = "Thiếu nhi" }
            );
        }
    }
}
