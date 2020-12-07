using AnimalCrossingWebApp.Data.Contexts;
using AnimalCrossingWebApp.Data.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Data.Repositories
{
    public class VillagerRepository : IVillagerRepository
    {
        public IConfiguration _Configuration { get; set; }
        private readonly VillagerContext _context;
        private readonly IMapper _mapper;

        public VillagerRepository(VillagerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        //public List<Villagers> GetAllVillagers()
        //{
        //    return _context.Villagers.ToList();
        //}

        public async Task<List<T>> GetAllVillagersAsync<T>()
        {
            var villagers = await _context.Villagers
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return villagers;
        }

        public async Task<List<T>> GetAllNorthFishAsync<T>()
        {
            var northfish = await _context.NorthFish
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return northfish;
        }

        public async Task<List<T>> GetAllSouthFishAsync<T>()
        {
            var southfish = await _context.SouthFish
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return southfish;
        }

        public async Task<List<T>> GetAllNorthBugAsync<T>()
        {
            var northbug = await _context.NorthBug
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return northbug;
        }

        public async Task<List<T>> GetAllSouthBugAsync<T>()
        {
            var southbug = await _context.SouthBug
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return southbug;
        }

        public async Task<List<T>> GetAllSpecialCharacters<T>()
        {
            var specialchars = await _context.SpecialCharacters
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return specialchars;
        }




    }
}
