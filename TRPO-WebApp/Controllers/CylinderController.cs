using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_WebApp.Models;

namespace TRPO_WebApp.Controllers
{

    public class CylinderController : Controller
    {
        public IActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(IFormCollection collection)
        {
            var cylinder = new CylinderModel
            {
                Radius = Convert.ToDouble(collection["Radius"]),
                Height = Convert.ToDouble(collection["Height"])
            };


            if (!ModelState.IsValid)
            {
                return View(cylinder);
            }
            var surfaceArea = cylinder.GetSurfaceArea();
            ViewBag.SurfaceArea = surfaceArea;

            return View(cylinder);
        }
    }
}
