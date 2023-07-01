using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebAPI.Repositories;
using MyWebAPI.Entities;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureRepository _furnitureRepository;
        public FurnitureController(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }
        //Display furniture by Id
        [HttpGet, Route("GetFurnitureById/{id}")]
        public IActionResult GetFurnitureById(int id)
        {
            try
            {
                Furniture furniture = _furnitureRepository.GetFurnitureById(id);
                if (furniture != null)
                    return StatusCode(200, furniture);
                else
                    return StatusCode(404, "Invalid Id");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }
        //Get furnitures by name
        [HttpGet, Route("GetFurnituresByName/{name}")]
        public IActionResult GetFurnitureByName(string name)
        {
            try
            {
                List<Furniture> furniture = _furnitureRepository.GetFurnitureByName(name);
                if (furniture != null)
                    return StatusCode(200, furniture);
                else
                    return StatusCode(404, "Invalid name");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        //get furnture by type
        [HttpGet, Route("GetFurntiresByType/{type}")]
        public IActionResult GetFurnitureByType(string type)
        {
            try
            {
                List<Furniture> furniture = _furnitureRepository.GetFurnitureByType(type);
                if (furniture != null)
                    return StatusCode(200, furniture);
                else
                    return StatusCode(404, "Invalid type");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        //Get all furnitures 
        [HttpGet, Route("GetAllFurnitures")]
        public IActionResult GetAllFurnitures()
        {
            try
            {
                List<Furniture> furnitures = _furnitureRepository.GetAllFurnitures();
                if (furnitures != null)
                    return StatusCode(200, _furnitureRepository.GetAllFurnitures());
                else
                    return StatusCode(501, "No Furniture added yet.");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        //Add new furniture
        [HttpPost, Route("AddNewFurniture")]
        public IActionResult Add(int id,string name,string type,int cost)
        {
            try
            {
                Furniture furniture = new Furniture() { Id = id, Name =name, Type=type,Cost =cost};
                _furnitureRepository.Add(furniture);
                return StatusCode(200, "Above Furniture Added Successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }
        //Update furniture
        [HttpPut, Route("EditFurniture")]
        public IActionResult Edit(Furniture furniture)
        {
            try
            {
                _furnitureRepository.Edit(furniture);
                return StatusCode(200, furniture);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        //Remove  Furniture
        [HttpDelete, Route("RemoveFurniture/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (_furnitureRepository.Delete(id))
                    return StatusCode(200, "Furniture Removed");
                else
                    return StatusCode(404, "Invalid Id");

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }
    }
}
