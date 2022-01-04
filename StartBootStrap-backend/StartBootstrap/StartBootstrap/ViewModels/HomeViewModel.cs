using StartBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.ViewModels
{
    public class HomeViewModel
    {
        public List<Setting> Settings { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<SosialMedia> SosialMedias { get; set; }
    }
}
