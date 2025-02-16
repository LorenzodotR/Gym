using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class TrainingHistory
    {
        [Key]
        public int Id { get; set; }

        public int Weight { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }  // Note: This should probably be string to match User.Id

        [ForeignKey("TrainingSheet")]
        public int TrainingSheetId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public TrainingSheet TrainingSheet { get; set; }
    }
}
