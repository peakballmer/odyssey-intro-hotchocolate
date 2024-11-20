namespace Odyssey.IntroHCListings.Types;

[GraphQLDescription("A particular intergalactic location available for booking")]
public class Listing
{
    [GraphQLDescription("The ID for the listing")]
    [ID]
    public string Id { get; }

    [GraphQLDescription("The listing's title")]
    public string Title { get; set; }

    [GraphQLDescription("The number of beds available")]
    public int? NumOfBeds { get; set; }

    [GraphQLDescription("The cost per night")]
    public double? CostPerNight { get; set; }

    [GraphQLDescription("Indicates whether listing is closed for bookings (on hiatus)")]
    public bool? ClosedForBookings { get; set; }

    public Listing(string id, string title)
    {
        Id = id;
        Title = title;
    }
}
