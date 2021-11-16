using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using You.DTOs;
using You.UI.DataAccess;

namespace You.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDataAccess _dataAccess;

        public IndexModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


        public List<CustomerDTO> Customers { get; set; }
        [BindProperty]
        public CustomerDTO Customer { get; set; }
        public void OnGet()
        {
            Customers = _dataAccess.GetAll().ToList();
        }


        public IActionResult OnPostSave()
        {
            if (ModelState.IsValid)
            {
                _dataAccess.SaveCustomer(Customer);
                return Page();
            }
            return Page();
        }
    }
}
