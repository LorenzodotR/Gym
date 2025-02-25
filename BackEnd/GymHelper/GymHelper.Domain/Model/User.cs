using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string Password { get; set; }

        // Navigation properties
        public ICollection<TrainingSheet> TrainingSheets { get; set; }
        public ICollection<Frequency> Frequencies { get; set; }
        public ICollection<Goal> Goals { get; set; }
        //public ICollection<Notification> Notifications { get; set; }
    }
}
