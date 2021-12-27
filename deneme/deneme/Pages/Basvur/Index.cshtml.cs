using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using deneme.Data;
using deneme.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;


namespace deneme.Pages.Basvur
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {

            _context = context;
        }

        public void OnGet()
        {
        }
        public int myid;

        [BindProperty]
        public IFormFile file1 { get; set; }
        [BindProperty]
        public IFormFile file2 { get; set; }
        [BindProperty]
        public IFormFile file3 { get; set; }
        [BindProperty]
        public IFormFile file4 { get; set; }
        [BindProperty]
        public IFormFile file5 { get; set; }
        [BindProperty]
        public IFormFile file6 { get; set; }
        [BindProperty]
        public IFormFile file7 { get; set; }

        [BindProperty]
        public Personel Personel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Table.Add(Personel);
            _context.SaveChanges();
            myid = Personel.Id;

            if (file1 != null)
            {
                if (file1.Length > 0 && file1.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target1 = new MemoryStream())
                    {
                        file1.CopyTo(target1);
                        myInv.Ikametgah = target1.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file2 != null)
            {
                if (file2.Length > 0 && file2.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target2 = new MemoryStream())
                    {
                        file2.CopyTo(target2);
                        myInv.Diploma = target2.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file3 != null)
            {
                if (file3.Length > 0 && file3.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target3 = new MemoryStream())
                    {
                        file3.CopyTo(target3);
                        myInv.Hizmetdokum = target3.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file4 != null)
            {
                if (file4.Length > 0 && file4.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target3 = new MemoryStream())
                    {
                        file4.CopyTo(target3);
                        myInv.Askerlik = target3.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file5 != null)
            {
                if (file5.Length > 0 && file5.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target3 = new MemoryStream())
                    {
                        file5.CopyTo(target3);
                        myInv.Ehliyet = target3.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file6 != null)
            {
                if (file6.Length > 0 && file6.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target3 = new MemoryStream())
                    {
                        file6.CopyTo(target3);
                        myInv.Fotograf = target3.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            if (file7 != null)
            {
                if (file7.Length > 0 && file7.Length < 500000)
                {
                    var myInv = _context.Table.FirstOrDefault(x => x.Id == myid);
                    using (var target3 = new MemoryStream())
                    {
                        file7.CopyTo(target3);
                        myInv.Adlisicil = target3.ToArray();
                    }
                    _context.Table.Update(myInv);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToPage("/Dosyaliste/Index");
        }





    }
}
