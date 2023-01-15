using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectAEWeb.Data;
using ProiectAEWeb.Models;

namespace ProiectAEWeb.Pages.Servicii
{
    public class CreateModel : PageModel
    {
        private readonly ProiectAEWeb.Data.ProiectAEWebContext _context;

        public CreateModel(ProiectAEWeb.Data.ProiectAEWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MarcaID"] = new SelectList(_context.Set<Marca>(), "ID","NumeMarca");
            ViewData["PersonalID"] = new SelectList(_context.Set<Personal>(), "ID", "Nume");
            ViewData["PersonalID"] = new SelectList(_context.Set<Personal>(), "ID", "Prenume");
            var serviciu = new Serviciu();
            //serviciu.CategoriServiciu = new List<CategorieServiciu>();
            //PopulateAssignedCategoryData(_context, serviciu);
            var personalList = _context.Personal.Select(x => new
            {
                x.ID,
                FullName = x.Nume + " " + x.Prenume
            });
            ViewData["PersonalID"] = new SelectList(personalList, "ID", "FullName");
            ViewData["MarcaID"] = new SelectList(_context.Marca, "ID",
           "NumeMarca");
            return Page();
            return Page();
        }

        [BindProperty]
        public Serviciu Serviciu { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Serviciu.Add(Serviciu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
