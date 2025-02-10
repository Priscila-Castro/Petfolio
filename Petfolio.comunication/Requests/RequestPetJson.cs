using Petfolio.Communication.Enums;

namespace Petfolio.comunication.Requests;
public class RequestPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set;}

}
