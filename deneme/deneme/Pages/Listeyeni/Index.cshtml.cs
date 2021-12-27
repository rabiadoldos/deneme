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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace deneme.Pages.Listeyeni
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;
        public IndexModel(DataContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string secilipoz { get; set; }
        public IList<Personel> Personels { get; set; }
       
        // public IList<Personel> Personel { get; set; }
        public SelectList pozss { get; set; }
        //public async Task OnGetAsync()
        //{
        //    // Use LINQ to get list of genres.
        //    IQueryable<string> genreQuery = from m in _context.Table
        //                                    orderby m.Pozisyon
        //                                    select m.Pozisyon;

        //    var movies = from m in _context.Table
        //                 select m;

        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        movies = movies.Where(s => s.Pozisyon.Contains(SearchString));
        //    }

        //    if (!string.IsNullOrEmpty(secilipoz))
        //    {
        //        movies = movies.Where(x => x.Pozisyon == secilipoz);
        //    }
        //    pozss = new SelectList(await genreQuery.Distinct().ToListAsync());
        //    Personels = await movies.ToListAsync();
        //}


        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Table
                                            orderby m.Pozisyon
                                            select m.Pozisyon;

            var movies = from m in _context.Table
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Ad.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(secilipoz))
            {
                movies = movies.Where(x => x.Pozisyon == secilipoz);
            }
            pozss = new SelectList(await genreQuery.Distinct().ToListAsync());
            Personels = await movies.AsNoTracking().ToListAsync();

        }
        public string fjpg= "application/jpg";
        public string diger= "application/pdf";
        public string pozadi;
        public string uzanti;
        
        public string mimeType;
        [BindProperty]
        public byte[] poz { get; set; }
        public async Task<IActionResult> OnPostDownloadAsync(int? id, int? rd)
        {
            var myInv = await _context.Table.FirstOrDefaultAsync(m => m.Id == id);
            if (rd == 1)
            {
                poz = myInv.Ikametgah;
                pozadi = "yerlesimyeri ";
                mimeType = diger;
                uzanti = ".pdf";
            }
            if (rd == 2)
            {
                poz = myInv.Diploma;
                pozadi = "diploma ";
                mimeType = diger;
                uzanti = ".pdf";
            }
            if (rd == 3)
            {
                poz = myInv.Hizmetdokum;
                pozadi = "hizmetdokum ";
                mimeType = diger;
                uzanti = ".pdf";
            }
            if (rd == 4)
            {
                poz = myInv.Askerlik;
                pozadi = "askerlik ";
                mimeType = diger;
                uzanti = ".pdf";
            }
            if (rd == 5)
            {
                poz = myInv.Ehliyet;
                pozadi = "ehliyet ";
                mimeType = diger;
                uzanti = ".pdf";
            }
            if (rd == 6)
            {
                poz = myInv.Fotograf;
                pozadi = "fotograf ";
                mimeType = fjpg;
                uzanti = ".jpg";
            }
            if (rd == 7)
            {
                poz = myInv.Adlisicil;
                pozadi = "adlisicil ";
                mimeType = diger;
                uzanti = ".pdf";
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

                byte[] byteArr = poz;
                
                return new FileContentResult(byteArr, mimeType)
                {
                    FileDownloadName = $"{pozadi} {myInv.Tc}{uzanti}"
                };
            }


        }


    }
}
