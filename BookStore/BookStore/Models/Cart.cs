using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
