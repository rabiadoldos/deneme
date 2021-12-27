using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using deneme.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace deneme.Pages.deneme
{
    public class IndexModel : PageModel
    {

       private readonly IWebHostEnvironment _environment;
        public IndexModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
         public IFormFile Uploadfiles { get; set; }
        public void OnGet()
        {

        }
        public async Task OnPostAsync()
        {
            var Fileupload = Path.Combine(_environment.ContentRootPath, "Files", Uploadfiles.FileName);
            using (var Fs = new FileStream(Fileupload, FileMode.Create))
            {
                await Uploadfiles.CopyToAsync(Fs);
                ViewData["Message"] = "se" + Uploadfiles.FileName + "succ";
            }
        }
    }

}

