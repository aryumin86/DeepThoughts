using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DeepThoughtsLib.Entities
{
    /// <summary>
    /// Collocutor profile - e.g. Pholosopher, Musician etc.
    /// May be a profession.
    /// </summary>
    [Table("profile")]
    public class Profile
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}
