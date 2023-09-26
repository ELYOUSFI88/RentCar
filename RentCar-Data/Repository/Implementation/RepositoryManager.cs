using RentCar_Data.DContext;
using RentCar_Data.Repository.Implementation;
using RentCar_Data.Repository.Signatures;
using RentCar_Model.Models;


namespace RentCar_Data.Repository.Implementation
{
    public class RepositoryManager:IRepositoryManager
    {
        private  RentCarContext _RentCarContext;
        private  IRepositoryAgence _RepositoryAgence;
        
        public RepositoryManager(RentCarContext RentCarContext)
        {
            _RentCarContext = RentCarContext;
        }

        public IRepositoryAgence Agence
        {
            get
            {
                if (_RepositoryAgence == null)
                    _RepositoryAgence = new RepositoryAgence(_RentCarContext);

                return _RepositoryAgence;

                //return new RepositoryArticle(_PortailContext);
            }
        }

        public Task SaveAsync() => _RentCarContext.SaveChangesAsync();
        public void Dispose()
        {
            _RentCarContext.Dispose();
        }
    }
}
