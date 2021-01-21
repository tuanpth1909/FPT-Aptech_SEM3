using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Practice.Models
{
    public interface HRMRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
