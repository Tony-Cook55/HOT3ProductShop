using Microsoft.AspNetCore.Mvc;
using ProductShop.Models;

namespace ProductShop.Controllers
{
    public class RecordController : Controller
    {



        private readonly RecordContext Context;

        public RecordController(RecordContext context)
        {
            Context = context;
        }




        public IActionResult ProductDetails()
        {
            return View();
        }





        [Route("record/{id}/{slug?}")]
        public IActionResult Details(int id)
        {
            var records = Context.Records.Find(id);
            if (records != null && records.ImageFileName != null)
            {
                records.ImageFileName = "/images/" + records.ImageFileName;
            }
            return View("ProductDetails", records);
        }


    }
}
