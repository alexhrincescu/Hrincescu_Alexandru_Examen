using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hrincescu_Alexandru_Examen.Data;
using Hrincescu_Alexandru_Examen.Models;

namespace Hrincescu_Alexandru_Examen.Pages.Jocuri
{
    public class EditModel : PageModel
    {
        private readonly Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext _context;

        public EditModel(Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JocuriVideo JocuriVideo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JocuriVideo = await _context.JocuriVideo.FirstOrDefaultAsync(m => m.ID == id);

            if (JocuriVideo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JocuriVideo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JocuriVideoExists(JocuriVideo.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JocuriVideoExists(int id)
        {
            return _context.JocuriVideo.Any(e => e.ID == id);
        }
    }
}
