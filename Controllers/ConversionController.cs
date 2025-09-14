using Microsoft.AspNetCore.Mvc;
using MetricSystem.Data;
using MetricSystem.Models;
using System.Linq;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        private readonly MetricSystemDbContext _db;
        public ConversionController(MetricSystemDbContext db) => _db = db;

        [HttpGet]
        public IActionResult Temperature() => View(new ConversionViewModel());

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public IActionResult Temperature(ConversionViewModel vm)
        {
             vm.Direction = "FtoC";
    if (!ModelState.IsValid)
        return View(vm);

    var f = vm.Input!.Value;
    vm.Result = (f - 32.0) * 5.0 / 9.0;

    // persist (optional)
    var rec = new TempConversion
    {
        Direction = vm.Direction,
        Input = f,
        Result = vm.Result.Value,
        CreatedUtc = DateTime.UtcNow
    };
    _db.TempConversion.Add(rec);
    _db.SaveChanges();

    return View(vm);
        }    
        public IActionResult History()
        {
            var last20 = _db.TempConversion
                .OrderByDescending(r => r.CreatedUtc)
                .Take(20)
                .ToList();
            return View(last20);
        }
    }
}
