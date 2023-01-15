using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectAEWeb.Data;
using ProiectAEWeb.Models;

namespace ProiectAEWeb.Pages.Personalul
{
    public class IndexModel : PageModel
    {
        private readonly ProiectAEWeb.Data.ProiectAEWebContext _context;

        public IndexModel(ProiectAEWeb.Data.ProiectAEWebContext context)
        {
            _context = context;
        }

        public IList<Personal> Personal { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Personal != null)
            {
                Personal = await _context.Personal.ToListAsync();
            }
        }
    }
}
