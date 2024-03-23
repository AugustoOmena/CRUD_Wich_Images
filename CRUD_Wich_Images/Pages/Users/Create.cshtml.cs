using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_Wich_Images.Data;
using CRUD_Wich_Images.Model;

namespace CRUD_Wich_Images.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext _context;

        public CreateModel(CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
