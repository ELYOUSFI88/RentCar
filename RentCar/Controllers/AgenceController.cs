using Microsoft.AspNetCore.Mvc;
using RentCar_Data.Repository.Signatures;
using RentCar_Model.Models;

namespace RentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgenceController : Controller
    {
        private readonly IRepositoryManager _repository;
        public AgenceController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Agence>> GetAgences()
        {
            var agences = await _repository.Agence.GetAgencesAsync();
            return agences;
        }

        [HttpGet("{id}")]
        public async Task<Agence> GetAgenceById(int id)
        {
            var agence = await _repository.Agence.GetAgenceAsync(id);
            return agence;
        }
    }
}
