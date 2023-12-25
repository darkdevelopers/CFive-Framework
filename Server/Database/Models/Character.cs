using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CFive_Framework.Server.Database.Models
{
    public class Character
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
    }
}