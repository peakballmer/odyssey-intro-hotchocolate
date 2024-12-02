namespace Odyssey.IntroHCListings.Types;

public class CreateListingInput
{
    [GraphQLDescription("The listing's title")]
    public string Title { get; set; }

    [GraphQLDescription("The listing's description")]
    public string Description { get; set; }

    [GraphQLDescription("The number of beds available")]
    public int NumOfBeds { get; set; }

    [GraphQLDescription("The cost per night")]
    public double CostPerNight { get; set; }

    [GraphQLDescription("Indicates whether listing is closed for bookings (on hiatus)")]
    public bool? ClosedForBookings { get; set; }

    [GraphQLDescription("The listing's amenities, represented by the string IDs.")]
    [ID]
    public string[]? Amenities { get; set; }

    public CreateListingInput(
        string title,
        string description,
        int numOfBeds,
        double costPerNight,
        bool? closedForBookings,
        string[]? amenities
    )
    {
        Title = title;
        Description = description;
        NumOfBeds = numOfBeds;
        CostPerNight = costPerNight;
        ClosedForBookings = closedForBookings;
        Amenities = amenities;
    }
}
