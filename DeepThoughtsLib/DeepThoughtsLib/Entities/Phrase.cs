using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeepThoughtsLib.Entities
{
    /// <summary>
    /// Phrase of somebody.
    /// </summary>
    [Table("phrase")]
    public class Phrase
    {
        [Key]
        public int Id { get; set; }
        public String Text { get; set; }

        public Collocutor Collocutor { get; set; }
        [ForeignKey("Collocutor")]
        public int CollocutorId { get; set; }

        public bool Active { get; set; }
    }
}
