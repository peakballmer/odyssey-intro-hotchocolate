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
}
