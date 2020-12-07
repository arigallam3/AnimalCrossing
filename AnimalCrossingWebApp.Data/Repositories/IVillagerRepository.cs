using AnimalCrossingWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Data.Repositories
{
    public interface IVillagerRepository
    {
        //List<Villagers> GetAllVillagers();
        Task<List<T>> GetAllVillagersAsync<T>();

        Task<List<T>> GetAllNorthFishAsync<T>();

        Task<List<T>> GetAllSouthFishAsync<T>();

        Task<List<T>> GetAllNorthBugAsync<T>();

        Task<List<T>> GetAllSouthBugAsync<T>();

        Task<List<T>> GetAllSpecialCharacters<T>();
    }
}
