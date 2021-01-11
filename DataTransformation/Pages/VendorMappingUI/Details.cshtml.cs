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
    public class DetailsModel : PageModel
    {
        private readonly DataTransformation.Data.DataTransformationContext _context;

        public DetailsModel(DataTransformation.Data.DataTransformationContext context)
        {
            _context = context;
        }

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
    }
}
