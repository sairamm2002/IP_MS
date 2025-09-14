using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TempModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")] 
        [Range(-459.67, 1000, ErrorMessage = "Fahrenheit must be between -459.67 and 1000.")]
        public decimal? Fahrenheit { get; set; }
        public decimal? Celsius { get; set; }
        public decimal? CalculateCelsius()
        {
                return (Fahrenheit - 32) * 5 / 9;
        }
    }
}