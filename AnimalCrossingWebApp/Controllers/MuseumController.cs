using AnimalCrossingWebApp.Common.Models;
using AnimalCrossingWebApp.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumController : ControllerBase
    {
        public IVillagerRepository _villagerRepository { get; set; }
        private readonly IMapper _mapper;

        public MuseumController(IVillagerRepository villagerRepository, IMapper mapper)
        {
            _villagerRepository = villagerRepository;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<List<NorthFishdto>> GetNorthFishes()
        {
            var northfishes = await _villagerRepository.GetAllNorthFishAsync<NorthFishdto>();
            return northfishes;
        }

        [HttpGet("[action]")]
        public async Task<List<SouthFishdto>> GetSouthFishes()
        {
            var southfishes = await _villagerRepository.GetAllSouthFishAsync<SouthFishdto>();
            return southfishes;
        }

        [HttpGet("[action]")]
        public async Task<List<NorthBugDto>> GetNorthBugs()
        {
            var northbugs = await _villagerRepository.GetAllNorthBugAsync<NorthBugDto>();
            return northbugs;
        }

        [HttpGet("[action]")]
        public async Task<List<SouthBugDto>> GetSouthBugs()
        {
            var southbugs = await _villagerRepository.GetAllSouthBugAsync<SouthBugDto>();
            return southbugs;
        }

        [HttpGet("[action]")]
        public async Task<List<SpecialCharacterDto>> GetSpecialCharacters()
        {
            var specialchars = await _villagerRepository.GetAllSpecialCharacters<SpecialCharacterDto>();
            return specialchars;
        }
    }
}
