using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebAPI.Entities;

namespace MyWebAPI.Repositories
{
    public interface IFurnitureRepository
    {
        public void Add(Furniture furniture);
        public void Edit(Furniture furniture);
        public bool Delete(int id);
        public List<Furniture> GetAllFurnitures();
        public Furniture GetFurnitureById(int id);
        public List<Furniture> GetFurnitureByName(string name);
        public List<Furniture> GetFurnitureByType(string type);

    }
}
