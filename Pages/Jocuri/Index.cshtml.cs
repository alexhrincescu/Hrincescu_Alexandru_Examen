using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hrincescu_Alexandru_Examen.Data;
using Hrincescu_Alexandru_Examen.Models;

namespace Hrincescu_Alexandru_Examen.Pages.Jocuri
{
    public class IndexModel : PageModel
    {
        private readonly Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext _context;

        public IndexModel(Hrincescu_Alexandru_Examen.Data.Hrincescu_Alexandru_ExamenContext context)
        {
            _context = context;
        }

        public IList<JocuriVideo> JocuriVideo { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Gen { get; set; }
        [BindProperty(SupportsGet = true)]
        public string GenJoc { get; set; }
        public async Task OnGetAsync()
        {

            IQueryable<string> genreQuery = from m in _context.JocuriVideo
                                            orderby m.Gen
                                            select m.Gen;
            var jocuri = from m in _context.JocuriVideo
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                jocuri = jocuri.Where(s => s.Titlu.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(GenJoc))
            {
                jocuri = jocuri.Where(x => x.Gen == GenJoc);
            }
            Gen = new SelectList(await genreQuery.Distinct().ToListAsync());

            JocuriVideo = await jocuri.ToListAsync();

        }
    }
}