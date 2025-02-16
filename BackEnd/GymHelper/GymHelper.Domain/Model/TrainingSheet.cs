using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class TrainingSheet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<MuscleGroup> MuscleGroups { get; set; }
        public ICollection<TrainingHistory> TrainingHistories { get; set; }
    }
}
