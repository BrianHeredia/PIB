using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pib.Models
{
    public class PBIS:DbContext
    {
        public PBIS(DbContextOptions<PBIS> options):base(options)
        {

        }
        
    }
}
