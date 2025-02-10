using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;
public class GetAllPetsUseCases
{
    public static ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets =
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Test",
                    Type = Communication.Enums.PetType.Dog
                }
            }
        };
    }
}
