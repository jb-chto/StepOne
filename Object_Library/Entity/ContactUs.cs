using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Object_Library.Entity
{
    [Table("ContactUs")]
    public class ContactUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactUsId { get; set; }

        [Column("date_of_send")]
        public DateTime DateOfSend { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Column("subject"), Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Column("readed")]
        public bool Readed { get; set; }

      
    }
}