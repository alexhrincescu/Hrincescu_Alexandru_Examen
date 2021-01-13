using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hrincescu_Alexandru_Examen.Data;
using Hrincescu_Alexandru_Examen.Models;

namespace Hrincescu_Alexandru_Examen.Pages.Jocuri
{
    public class DeleteModel : PageModel
    {
        private readonly Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext _context;

        public DeleteModel(Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JocuriVideo = await _context.JocuriVideo.FindAsync(id);

            if (JocuriVideo != null)
            {
                _context.JocuriVideo.Remove(JocuriVideo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
