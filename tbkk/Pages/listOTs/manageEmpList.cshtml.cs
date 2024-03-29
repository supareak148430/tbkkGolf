﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.listOTs
{
    public class manageEmpListModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public manageEmpListModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public IList<DetailOT> DetailOT { get;set; }

        public async Task<IActionResult> OnGetAsync(int? id, int? emp)
        {

            DetailOT = await _context.DetailOT
                .Include(d => d.CarType)
                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).ToListAsync();


            return Page();
            
        }
    }
}
