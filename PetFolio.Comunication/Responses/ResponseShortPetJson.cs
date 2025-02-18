using PetFolio.Comunication.Enums;

namespace PetFolio.Comunication.Responses;

public class ResponseShortPetJson
{

    public int Id { get; set; }
    public string Name { get; set; }

    public PetType PetType { get; set; }

}
