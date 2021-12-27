using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using deneme.Data;
using deneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace deneme.Pages.Liste
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;
        public IndexModel(DataContext context)
        {
            _context = context;
        }
        
        public List<Personel> Personels { get; set; }
        public void OnGet()
        {
            Personels = _context.Table.ToList();
           
        }
        public string pozadi;
        [BindProperty]
        public byte[] poz { get; set; }
        public async Task<IActionResult> OnPostDownloadAsync(int? id, int? rd)
        {
            var myInv = await _context.Table.FirstOrDefaultAsync(m => m.Id == id);
            if (rd == 1)
            {
                poz = myInv.Ikametgah;
                pozadi = "yerlesimyeri ";
            }
            if (rd == 2)
            {
                poz = myInv.Diploma;
                pozadi = "diploma ";
            }
            if (rd == 3)
            {
                poz = myInv.Hizmetdokum;
                pozadi = "hizmetdokum ";
            }
            if (myInv == null)
            {
                return NotFound();
            }

            if (myInv == null)
            {
                return Page();
            }
            else
            {

                byte[] byteArr =poz;
                string mimeType = "application/pdf";
                return new FileContentResult(byteArr, mimeType)
                {
                    FileDownloadName = $"{pozadi} {myInv.Tc}.pdf"
                };
            }
            

        }


    }
}
