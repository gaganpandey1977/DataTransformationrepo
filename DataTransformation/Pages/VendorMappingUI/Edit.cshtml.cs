using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataTransformation.Data;
using DataTransformation.Models;

namespace DataTransformation.Pages.VendorMappingUI
{
    public class EditModel : PageModel
    {
        private readonly DataTransformation.Data.DataTransformationContext _context;

        public EditModel(DataTransformation.Data.DataTransformationContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VendorMapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorMappingExists(VendorMapping.MappingID))
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

        private bool VendorMappingExists(int id)
        {
            return _context.VendorMapping.Any(e => e.MappingID == id);
        }
    }
}
