using Microsoft.EntityFrameworkCore;
using StartBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Services
{
    public class LayoutService
    {
        private DataContext _context;
        public LayoutService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Setting>> GetSettings()
        {
            return await _context.Settings.ToListAsync();
        }
        public async Task<List<SosialMedia>> GetSosialMedias()
        {
            return await _context.SosialMedias.ToListAsync();
        }
    }
}
