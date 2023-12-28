using AspNetCoreHero.ToastNotification.Abstractions;
using HealthApp.Data;
using HealthApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INotyfService _notyfService;
        public AppointmentController(ApplicationDbContext context,INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [Route("/api/getpatient")]
        [HttpGet]
        public IActionResult GetPatientList()
        {
            var pt = _context.Appointment.ToList();
            return Ok(pt);
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if(ModelState.IsValid)
            {
                _context.Add(appointment);
               var count= _context.SaveChanges();
                if (count>0)
                {
                    _notyfService.Success("Your appointment has been submitted successfully!!!");
                }
                else
                {
                    _notyfService.Error("Something went wrong!!!");
                   
                }
            }
            return RedirectToAction("Create");
        }
    }
}
