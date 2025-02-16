using System.ComponentModel.DataAnnotations;

namespace GymHelper.Model
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }
        [Required, MaxLength(4000)]
        public string Message { get; set; }
        [Required, MaxLength(50)]
        public string Level { get; set; }
        [Required]
        public DateTimeOffset LogDate { get; set; }
    }
}
