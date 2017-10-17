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
        public int Id { get; set; }
        public string FullName { get; set; }

        public Profile Profile { get; set; }
        [ForeignKey("Profile")]
        public int ProfileId { get; set; }

        public bool Active { get; set; }
    }
}
