using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using deneme.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.calis
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {

            _context = context;
        }
        public int? myID { get; set; }

        [BindProperty]
        public IFormFile file { get; set; }

        [BindProperty]
        public int? ID { get; set; }
        public void OnGet(int? id)
        {
            myID = id;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (file != null)
            {
                if (file.Length > 0 && file.Length < 300000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == ID);

                    using (var target = new MemoryStream())
                    {
                        file.CopyTo(target);
                        myInv.Ikametgah = target.ToArray();
                    }

                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }

            }

            return RedirectToPage("./Index");
        }
    }
}
