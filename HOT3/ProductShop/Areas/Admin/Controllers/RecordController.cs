using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductShop.Models;

namespace ProductShop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class RecordController : Controller
    {


        private readonly RecordContext Context;

        public RecordController(RecordContext context)
        {
            Context = context;
        }





        // ------ EDITING A RECORD ------ \\
        [HttpGet]
        public ViewResult Edit(int id)
        {

            //LINQ Query to find the Record with the given id - PK Search
            var record = Context.Records.Find(id);

            ViewBag.AddOrEdit = "Edit";



            return View("AddEdit", record); // sends the RECORD to the edit page to auto fill the info
        }
        // ------ EDITING A RECORD ------ \\



        // ++++++++++++++++++++ ADDING RECORD ++++++++++++++++++++ \\
        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var record = Context.Records.Find(id.Value);
                if (record != null)
                {
                    return View("AddEdit", record);
                }
            }

            ViewBag.AddOrEdit = "Add";

            return View("AddEdit", new Record());
        }





        [HttpPost]
        public IActionResult Edit(Record record)
        {
            //Add operation if id is 0

            if (ModelState.IsValid)
            {
                if (record.RecordId == 0)
                {
                    Context.Records.Add(record);
                }
                else
                {
                    Context.Records.Update(record);
                }

                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (record.RecordId == 0) ? "Add" : "Edit";


                return View(record);
            }
        }
        // ++++++++++++++++++++ ADDING RECORD ++++++++++++++++++++ \\











        // ------------------ DELETING RECORD ------------------ \\
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = Context.Records.Find(id);
            if (record != null)
            {
                ViewBag.RecordName = record.RecordName;
                return View(record);
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult DeleteRecord(Record record)
        {
            if (record != null)
            {
                Context.Records.Remove(record);
                Context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        // ------------------ DELETING RECORD ------------------ \\


    }
}
