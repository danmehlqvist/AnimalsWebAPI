using AnimalsWebAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWebAPI.Tests.AnimalsController
{
    public class AnimalsControllerTestData
          
    {
        public Animal oneAnimal;

        public List<Animal> threeAnimals;

        public List<AnimalType> animalTypes;

        public AnimalsControllerTestData()
        {
            animalTypes = new List<AnimalType>
            {
                new AnimalType
                {
                    Name ="AnimalType 1",
                    ID = 1,
                    Created= new DateTime(2001,1,1),
                    NumberOfLegs=1
                },
                  new AnimalType
                {
                    Name ="AnimalType 2",
                    ID = 2,
                    Created= new DateTime(2002,2,2),
                    NumberOfLegs=2
                },
                new AnimalType
                {
                    Name ="AnimalType 3",
                    ID = 3,
                    Created= new DateTime(2003,3,3),
                    NumberOfLegs=3
                }
            };


            oneAnimal = new Animal
            {
                Name = "Animal 1",
                AnimalTypeID = 1,
                AnimalType = animalTypes.First(x => x.ID == 1),
                Created = new DateTime(2001, 1, 1),
                DateOfBirth = new DateTime(2000, 1, 1),
                ID = 1,
            };

            threeAnimals = new List<Animal>
            {
                oneAnimal,
                new Animal
                {
                    Name = "Animal 2",
                    AnimalTypeID = 2,
                    AnimalType = animalTypes.First(x => x.ID== 2),
                    Created = new DateTime(2002, 2, 2),
                    DateOfBirth = new DateTime(2000, 2, 2),
                    ID = 2,
                },
                new Animal
                {
                    Name = "Animal 3",
                    AnimalTypeID = 3,
                    AnimalType = animalTypes.First(x => x.ID== 3),
                    Created = new DateTime(2003, 3, 3),
                    DateOfBirth = new DateTime(2000, 3, 3),
                    ID = 3,
                }
            };

    }


}
}
