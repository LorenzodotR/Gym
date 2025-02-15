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

        public long Weight { get; set; }
        public long Repetitions { get; set; }
        public long Sets { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }  // Note: This should probably be string to match User.Id

        [ForeignKey("TrainingSheet")]
        public long TrainingSheetId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public TrainingSheet TrainingSheet { get; set; }
    }
}
