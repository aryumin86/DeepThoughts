using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DeepThoughtsLib.Entities
{
    /// <summary>
    /// Collocutor.
    /// </summary>
    [Table("collocutor")]
    public class Collocutor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("fullname")]
        public string FullName { get; set; }

        public Profile Profile { get; set; }
        [ForeignKey("Profile")]
        [Column("profileid")]
        public int ProfileId { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
