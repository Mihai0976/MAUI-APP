namespace MuiBrakefast.Models;
    public record  Brakefast(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        Uri Image,
        List<string>Savory,
        List<string>Sweets
        );
    