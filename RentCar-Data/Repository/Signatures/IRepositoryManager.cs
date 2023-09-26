using RentCar_Data.Repository.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar_Data.Repository.Signatures
{
   public  interface IRepositoryManager : IDisposable
    {
        IRepositoryAgence Agence { get; }
        Task SaveAsync();
    }
}
