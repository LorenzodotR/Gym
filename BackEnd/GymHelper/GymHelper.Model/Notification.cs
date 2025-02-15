using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        public long Message { get; set; }  // Note: This might need to be changed to string based on your actual needs
        public long SendAt { get; set; }   // Note: This might need to be changed to DateTime based on your actual needs
        public long Status { get; set; }

        [ForeignKey("Goal")]
        public long GoalId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        // Navigation properties
        public Goal Goal { get; set; }
        public User User { get; set; }
    }
}
