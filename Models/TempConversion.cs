using System;
using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TempConversion
    {
        public int Id { get; set; }

        [Required]
        public string Direction { get; set; } = "FtoC"; // FtoC or CtoF

        [Required]
        public double Input { get; set; }

        public double Result { get; set; }

        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
