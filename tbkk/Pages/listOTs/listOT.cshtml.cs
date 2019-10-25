﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.listOTs
{
    public class listOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public listOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public IList<OT> OT { get;set; }
        public Employee Employee { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OT = await _context.OT.ToListAsync();
           
            OT = OT.Where(s=> s.TypStatus.Equals("Open")).ToList();

            Employee = await _context.Employee
                 .Include(e => e.Company)
                 .Include(e => e.Department)
                 .Include(e => e.EmployeeType)
                 .Include(e => e.Location)
                 .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();

        }
        

       
    }
}
