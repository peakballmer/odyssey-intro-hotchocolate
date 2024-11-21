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

    [GraphQLDescription("The listing's description")]
    public string Description { get; set; }

    [GraphQLDescription("The amenities available for this listing")]
    public List<Amenity> Amenities { get; set; }

    public Listing(string id, string title, string description, List<Amenity>? amenities)
    {
        Id = id;
        Title = title;
        Description = description;

        Amenities = amenities;
    }

    public Listing(ListingsDataSource.Listing obj)
    {
        Id = obj.Id;
        Title = obj.Title;
        NumOfBeds = obj.NumOfBeds;
        CostPerNight = obj.CostPerNight;
        ClosedForBookings = obj.ClosedForBookings;
        Description = obj.Description;

        Amenities = obj.Amenities.Select(amenity => new Amenity(amenity)).ToList();
    }
}
