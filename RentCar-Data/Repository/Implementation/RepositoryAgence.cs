using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar_Data.DContext;
using RentCar_Data.Repository.Signatures;
using RentCar_Model.Models;

namespace RentCar_Data.Repository.Implementation
{
    public class RepositoryAgence:RepositoryBase<Agence>,IRepositoryAgence
    {
        public RepositoryAgence(RentCarContext RentCarContext)
            : base(RentCarContext)
        {

        }
        public async Task<List<Agence>> GetAgencesAsync()
        {
            return await RentCarContext.Agences.ToListAsync();
        }

        public async Task<Agence> GetAgenceAsync(int id)
        {
            var agence = await RentCarContext.Agences.FindAsync(id); 
            if(agence != null)
            {
                return agence;
            }
            else
            {
                return new Agence();
            }
        }

        
    }
}
