using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalCrossingWebApp.Common.Models;
using AnimalCrossingWebApp.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalCrossingWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillagerController : ControllerBase
    {
        public IVillagerRepository _villagerRepository { get; set; }
        private readonly IMapper _mapper;

        public VillagerController(IVillagerRepository villagerRepository, IMapper mapper)
        {
            _villagerRepository = villagerRepository;
            _mapper = mapper; 
        }

        [HttpGet("[action]")]
        public async Task<List<VillagersDto>> GetVillagers()
        {
            var villagers = await _villagerRepository.GetAllVillagersAsync<VillagersDto>();
            return villagers;
        }

        //public IActionResult GetVillagers()
        //{
        //    try
        //    {
        //        return Ok(_villagerRepository.GetAllVillagersAsync());
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
        //    }

        //}

    }
}
