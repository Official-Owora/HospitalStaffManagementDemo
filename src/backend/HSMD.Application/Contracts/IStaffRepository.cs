using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffAsync(bool trackChanges);
        Task<Staff> GetStaffByIdAsync(int Id, bool trackChanges);
        Task<Hospital> GetStaffByName(string FirstName, string LastName, bool trackChanges);
        void CreatStaff(Staff staff);
        void DeleteStaff(Staff staff);
    }
}
