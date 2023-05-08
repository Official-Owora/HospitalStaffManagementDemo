using HSMD.Domain.Models;

namespace HSMD.Application.Contracts
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAllHospitalAsync(bool trackChanges);
        Task<Hospital> GetHospitalAsync(int Id, bool trackChanges);
        Task<Hospital> GetHospitalByName(string HospitalName, bool trackChanges);
        void CreateHospital(Hospital hospital);
        void DeleteHospital(Hospital hospita);
    }
}
