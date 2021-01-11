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
    public class IndexModel : PageModel
    {
        private readonly DataTransformation.Data.DataTransformationContext _context;

        public IndexModel(DataTransformation.Data.DataTransformationContext context)
        {
            _context = context;
        }

        public IList<VendorMapping> VendorMapping { get;set; }

        public async Task OnGetAsync()
        {
            VendorMapping = await _context.VendorMapping.ToListAsync();
        }
    }
}
