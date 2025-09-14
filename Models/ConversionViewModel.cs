using System.ComponentModel.DataAnnotations;
namespace MetricSystem.Models
{
    public class ConversionViewModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")]
        [Range(-1000, 1000, ErrorMessage = "Value must be between -1000 and 1000")]
        public double? Input { get; set; }

        [Required]
        public string Direction { get; set; } = "FtoC"; // or "CtoF"

        public double? Result { get; set; }
    }
}
