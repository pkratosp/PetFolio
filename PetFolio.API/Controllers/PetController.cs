using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetFolio.Application.useCases.Pets.DeletePet;
using PetFolio.Application.useCases.Pets.GetAll;
using PetFolio.Application.useCases.Pets.GetById;
using PetFolio.Application.useCases.Pets.Register;
using PetFolio.Application.useCases.Pets.Update;
using PetFolio.Comunication.Requests;
using PetFolio.Comunication.Responses;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson body)
    {

        var response = new RegisterPetUseCase().Execute(body:  body);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson body)
    {
        new UpdatePetUseCase().Execute(id: id, body: body);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase().Execute();

        if(useCase.Pets.Any()) { 
            return Ok(useCase);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetPet([FromRoute] int id) 
    {
        var useCase = new GetPetByIdUseCase().Execute(id: id);

        return Ok(useCase);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult DeletePet(int id) 
    {
        new DeletePetUseCase().Execute(id: id);

        return NoContent();
    }
}
