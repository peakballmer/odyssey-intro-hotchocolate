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

    private bool hasNullAmenityProperties()
    {
        if (_amenities == null)
        {
            return true;
        }

        // an array of booleans - true if the amenity contains a null property
        var hasNullProperties = _amenities.Select(
            amenity =>
                amenity
                    .GetType()
                    .GetProperties()
                    .Any(propertyInfo => propertyInfo.GetValue(amenity) == null)
        );

        return hasNullProperties.Any(a => a);
    }

    [GraphQLDescription("The amenities available for this listing")]
    public async Task<List<Amenity>> Amenities(ListingsDataSource.ListingsService listingsService)
    {
        if (_amenities == null || hasNullAmenityProperties())
        {
            var response = await listingsService.GetListingAmenitiesAsync(this.Id);
            return response.Select(amenity => new Amenity(amenity)).ToList();
        }
        else
        {
            return _amenities;
        }
    }

    private List<Amenity>? _amenities;

    public Listing(string id, string title, string description, List<Amenity>? amenities)
    {
        Id = id;
        Title = title;
        Description = description;

        _amenities = amenities;
    }

    public Listing(ListingsDataSource.Listing obj)
    {
        Id = obj.Id;
        Title = obj.Title;
        NumOfBeds = obj.NumOfBeds;
        CostPerNight = obj.CostPerNight;
        ClosedForBookings = obj.ClosedForBookings;
        Description = obj.Description;

        _amenities = obj.Amenities.Select(amenity => new Amenity(amenity)).ToList();
    }
}
