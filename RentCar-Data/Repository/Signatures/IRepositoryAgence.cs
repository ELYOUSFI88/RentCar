using RentCar_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar_Data.Repository.Signatures
{
    public interface IRepositoryAgence
    {
        public Task<List<Agence>> GetAgencesAsync();
        public Task<Agence> GetAgenceAsync(int id);
    }
}
