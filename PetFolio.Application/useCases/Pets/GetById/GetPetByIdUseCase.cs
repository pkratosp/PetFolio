using PetFolio.Comunication.Responses;

namespace PetFolio.Application.useCases.Pets.GetById;

public class GetPetByIdUseCase
{

    public ResponsePetJson Execute(int id)
    {

        return new ResponsePetJson
        {
            Id = 1,
            Birthday = new DateTime(year: 2024, month: 01, day: 01),
            Name = "Jest",
            Type = Comunication.Enums.PetType.Dog
        };
    }
}
