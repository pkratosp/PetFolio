using PetFolio.Comunication.Requests;
using PetFolio.Comunication.Responses;

namespace PetFolio.Application.useCases.Pets.Register;

public class RegisterPetUseCase
{

    public ResponseRegisterPetJson Execute(RequestRegisterPetJson body)
    {

        return new ResponseRegisterPetJson
        {
            Id = 1,
            Name = body.Name,
        };
    }

}
