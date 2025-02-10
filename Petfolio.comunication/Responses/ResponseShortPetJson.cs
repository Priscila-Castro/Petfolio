using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class ResponseShortPetJson
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public PetType type { get; set; }
    public required object Type { get; set; }
}
