using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Practice.Models
{
    public class EFHRMRepository : HRMRepository
    {
        HRMDbContext context;

        public EFHRMRepository(HRMDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
