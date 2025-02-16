using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHelper.Model
{
    public class MuscleGroup
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }  // Note: This might need to be changed to string based on your actual needs
        public string Description { get; set; }  // Note: This might need to be changed to string based on your actual needs

        [ForeignKey("TrainingSheet")]
        public int TrainingSheetId { get; set; }

        // Navigation properties
        public TrainingSheet TrainingSheet { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
