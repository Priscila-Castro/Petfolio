using Petfolio.comunication.Requests;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name,
        };
    }
}
