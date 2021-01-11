using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataTransformation.Data;
using DataTransformation.Models;

namespace DataTransformation.Pages.VendorMappingUI
{
    public class CreateModel : PageModel
    {
        private readonly DataTransformation.Data.DataTransformationContext _context;

        public CreateModel(DataTransformation.Data.DataTransformationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VendorMapping VendorMapping { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VendorMapping.Add(VendorMapping);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
