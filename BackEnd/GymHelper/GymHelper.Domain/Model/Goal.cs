using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }

        public int Type { get; set; }
        public int Target { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        // Navigation properties
        public User User { get; set; }
        //public ICollection<Notification> Notifications { get; set; }
    }
}
