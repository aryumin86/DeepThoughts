using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeepThoughtsLib.Entities
{
    [Table("userrequest")]
    public class UserRequest
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        [NotMapped]
        public List<int> ExcludeThesePhrases;
    }
}
