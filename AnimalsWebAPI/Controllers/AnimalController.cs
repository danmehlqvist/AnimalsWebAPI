using AnimalsWebAPI.Classes;
using AnimalsWebAPI.Data.Entities;
using AnimalsWebAPI.DTOs;
using AnimalsWebAPI.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsWebAPI.Controllers
{
    [Route("api/animal")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepo _animalRepo;

        public AnimalController(IAnimalRepo animalRepo)
        {
            this._animalRepo = animalRepo;
        }



        // blabla/animals?page=1&itemperpage=4
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            List<AnimalDTO> animals = _animalRepo.GetAll().ToAnimalDTOs();
            PaginationResult<AnimalDTO> paginatedResult = new PaginationResult<AnimalDTO>(animals, 2, 2);
            return Ok(new { 
                paginatedResult.CurrentPage, 
                paginatedResult.TotalPages, 
                paginatedResult.DataToReturn,
                paginatedResult.TotalItems
            });
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByID(int id)
        {
            Animal result = _animalRepo.Get(id);
            if (result is null)
            {
                return NotFound($"The animal with ID {id} could not be found");
            }
            return Ok(result.ToAnimalDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            Animal animalToDelete = _animalRepo.Get(id);
            if (animalToDelete is null)
            {
                return NotFound();
            }

            _animalRepo.Delete(animalToDelete);
            return NoContent();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody]CreateAnimalDTO animal)
        {
            Animal createdAnimal = _animalRepo.Create(animal);
            return CreatedAtAction(
                nameof(Post),
                new { id = createdAnimal.ID},
                createdAnimal);
        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody]UpdateAnimalDTO animal)
        {
            Animal updatedAnimal = _animalRepo.Update(animal);
            if (updatedAnimal is null)
            {
                return NotFound();
            }

            return Ok(updatedAnimal);
        }

    }
}
