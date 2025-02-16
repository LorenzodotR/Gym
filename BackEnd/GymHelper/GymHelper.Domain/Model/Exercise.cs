using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        public int Repeat { get; set; }
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Pause { get; set; }

        [ForeignKey("MuscleGroup")]
        public int MuscleGroupId { get; set; }

        // Navigation property
        public MuscleGroup MuscleGroup { get; set; }
    }
}
