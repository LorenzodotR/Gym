using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class Frequency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public bool? Attendance { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }  // Note: This should probably be string to match User.Id

        // Navigation properties
        public User User { get; set; }
        public ICollection<ExtraActivity> ExtraActivities { get; set; }
    }
}
