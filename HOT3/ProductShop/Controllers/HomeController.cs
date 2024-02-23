using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductShop.Models;
using System.Diagnostics;

namespace ProductShop.Controllers
{
    public class HomeController : Controller
    {

        private readonly RecordContext Context;

        public HomeController(RecordContext context)
        {
            Context = context;
        }





        [Route("/{artist?}")]
        public IActionResult Index(string artist = "all")
        {

            List<Record> records;

            if (artist.Equals("all")) // artist == all  by default thus the items will show
            {
                records = Context.Records.ToList();
            }
            else //
            {
                records = Context.Records.Where(b => b.ArtistName == artist).ToList();
            }

            return View(records);
        }











    }
}
