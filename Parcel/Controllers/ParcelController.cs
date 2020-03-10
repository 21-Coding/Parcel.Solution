using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll(); 
      return View(allParcels);
    }

    [HttpGet("/parcels")]
    public ActionResult Create(int height, int depth, int width, int weight)
    {
      Parcel parcel = new Parcel(height, depth, width, weight)

      return RedirectToAction("Index", "");
    }











  }
}