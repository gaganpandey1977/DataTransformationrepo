using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataTransformation.Data;
using DataTransformation.Models;

namespace DataTransformation.Pages.VendorMappingUI
{
    public class DeleteModel : PageModel
    {
        private readonly DataTransformation.Data.DataTransformationContext _context;

        public DeleteModel(DataTransformation.Data.DataTransformationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VendorMapping VendorMapping { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VendorMapping = await _context.VendorMapping.FirstOrDefaultAsync(m => m.MappingID == id);

            if (VendorMapping == null)
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

            VendorMapping = await _context.VendorMapping.FindAsync(id);

            if (VendorMapping != null)
            {
                _context.VendorMapping.Remove(VendorMapping);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
