using Microsoft.Identity.Client;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        //private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            //_context = context;
        }
    }
}
