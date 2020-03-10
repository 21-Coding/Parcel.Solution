using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet ("/")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll(); 
      return View(allParcels);
    }
  }
}