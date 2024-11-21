namespace Odyssey.IntroHCListings.Types;

public class Query
{
    [GraphQLDescription("A curated array of listings to feature on the homepage")]
    public async Task<List<Listing>> FeaturedListings(
        ListingsDataSource.ListingsService listingsService
    )
    {
        var response = await listingsService.GetFeaturedListingsAsync();
        return response.Select(listing => new Listing(listing)).ToList();
    }

    [GraphQLDescription("Retrieves a specific listing's details.")]
    public async Task<Listing?> GetListing(
        [ID] string id,
        ListingsDataSource.ListingsService listingsService
    )
    {
        var response = await listingsService.GetListingDetailsAsync(id);
        var listing = new Listing(response);
        return listing;
    }
}
