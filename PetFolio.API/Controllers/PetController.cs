using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetFolio.Application.useCases.Pet.Register;
using PetFolio.Comunication.Requests;
using PetFolio.Comunication.Responses;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status200OK)]
    public IActionResult Register([FromBody] RequestRegisterPetJson body)
    {

        var response = new RegisterPetUseCase().Execute(body:  body);

        return Created(string.Empty, response);
    }
}
