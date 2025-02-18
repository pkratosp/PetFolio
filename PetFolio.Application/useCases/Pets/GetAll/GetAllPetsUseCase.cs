using PetFolio.Comunication.Responses;

namespace PetFolio.Application.useCases.Pets.GetAll;

public class GetAllPetsUseCase
{

    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson { 
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "jest",
                    PetType = Comunication.Enums.PetType.Cat
                }

            }
        };
    }

}
