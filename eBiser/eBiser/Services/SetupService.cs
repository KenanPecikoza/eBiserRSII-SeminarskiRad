using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class SetupService
    {
        public static void Init(eBiserContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
