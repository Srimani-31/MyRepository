using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using MyWebAPI.Entities;

namespace MyWebAPI.Repositories
{
    public class FurnitureRepository : IFurnitureRepository
    {
        
        private readonly FurnitureContext _context;
        public FurnitureRepository(FurnitureContext context)
        {
            _context = context;
        }
        //Add new furniture to the table
        public void Add(Furniture furniture)
        {
            try
            {
                _context.Furnitures.Add(furniture);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
        //Update exisiting furniture details
        public void Edit(Furniture furniture)
        {
            try
            {
                _context.Furnitures.Update(furniture);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
        //Delete furniture details
        public bool Delete(int id)
        {
            try
            {
                Furniture furniture = _context.Furnitures.Find(id);
                if (furniture != null)
                {
                    _context.Furnitures.Remove(furniture);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        //Show all furnitures
        public List<Furniture> GetAllFurnitures()
        {
            try
            {
                List<Furniture> furnitures = _context.Furnitures.ToList();
                return furnitures;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Display furniture by id
        public Furniture GetFurnitureById(int id)
        {
            try
            {
                Furniture furniture = _context.Furnitures.Find(id);
                return furniture;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Display furnitures by name
        public List<Furniture> GetFurnitureByName(string name)
        {
            try
            {
                List<Furniture> furnitures = _context.Furnitures.Where(x => x.Name == name).ToList();
                return furnitures;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Display furnitures by type
        public List<Furniture> GetFurnitureByType(string type)
        {
            try
            {
                List<Furniture> furnitures = _context.Furnitures.Where(x => x.Type == type).ToList();
                return furnitures;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
