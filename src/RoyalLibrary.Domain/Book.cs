using RoyalLibrary.Core.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalLibrary.Domain
{
    [Table("books")]
    public class Book : DefaultEntity
    {
        [Key]
        [Column("book_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? BookId { get; set; }

        [Column("title")]
        public required string Title { get; set; }

        [Column("first_name")]
        public required string FirstName { get; set; }

        [Column("last_name")]
        public required string LastName { get; set; }

        [Column("total_copies")]
        public required int TotalCopies { get; set; }

        [Column("copies_in_use")]
        public required int CopiesInUse { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("isbn")]
        public string? Isbn { get; set; }

        [Column("category")]
        public string? Category { get; set; }
    }
}