namespace Odyssey.IntroHCListings.Types;

using ListingsDataSource;

public class Mutation
{
    [GraphQLDescription("Creates a new listing.")]
    public async Task<CreateListingResponse> CreateListing(
        CreateListingInput input,
        ListingsService listingsService
    )
    {
        var listingInputObj = new ListingInputObject
        {
            Title = input.Title,
            Description = input.Description,
            NumOfBeds = input.NumOfBeds,
            CostPerNight = input.CostPerNight,
            ClosedForBookings = input.ClosedForBookings,
            Amenities = input.Amenities
        };

        var body = new ListingInput { Listing = listingInputObj };

        try
        {
            var response = await listingsService.CreateListingAsync(body);
            return new CreateListingResponse(
                200,
                true,
                "Successfully created listing",
                new Listing(response)
            );
        }
        catch (Exception e)
        {
            return new CreateListingResponse(500, false, e.Message, null);
        }
    }
}
