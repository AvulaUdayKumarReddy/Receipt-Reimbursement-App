using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Receipt_Reimbursement_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Receipt_Reimbursement_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReimbursementController : Controller
    {
       
        private readonly ReimbursementDbContext _context;

        public ReimbursementController(ReimbursementDbContext context)
        {
            _context = context;
        }
        // POST api/<ReimbursementController>
        [HttpPost("AddReimbursement")]
        public async Task<IActionResult> AddReimbursement([FromForm] Reimbursement reimbursement, IFormFile File)
        {

            if(!ModelState.IsValid)
            {
                //to see if all requirements that are mentioned in annotations gets true.
                return View(reimbursement);
            }
            byte[]? fileBytes = null;
            string? fileName = null;
            string? fileType = null;
          
            if (File != null && File.Length > 0)
            {
                using (var ms = new MemoryStream())
                { 

                    //file parsing
                    await File.CopyToAsync(ms);
                    fileBytes = ms.ToArray();
                    fileName = File.FileName;
                    fileType = File.ContentType;
                }
            }
            //file assignment to model
            reimbursement.FileData= fileBytes;
            reimbursement.FileName= fileName;
            reimbursement.ContentType= fileType;
            _context.Reimbursements.Add(reimbursement);
            await _context.SaveChangesAsync();
            return RedirectToAction("Success", "Home"); ;
        }

       
    }
}
