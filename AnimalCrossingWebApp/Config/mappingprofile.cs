using AnimalCrossingWebApp.Common.Models;
using AnimalCrossingWebApp.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Config
{
    public class mappingprofile : Profile
    {
        public mappingprofile()
        {
            CreateMap<Villagers, VillagersDto>()
                .ReverseMap();

            CreateMap<NorthFish, NorthFishdto>()
                .ReverseMap();

            CreateMap<SouthFish, SouthFishdto>()
                .ReverseMap();

            CreateMap<NorthBug, NorthBugDto>()
                .ReverseMap();

            CreateMap<SouthBug, SouthBugDto>()
                .ReverseMap();

            CreateMap<SpecialCharacters, SpecialCharacterDto>()
                .ReverseMap();
        }
    }
}
