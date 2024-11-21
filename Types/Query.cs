namespace Odyssey.IntroHCListings.Types;

public class Query
{
    [GraphQLDescription("A curated array of listings to feature on the homepage")]
    public List<Listing> FeaturedListings()
    {
        return new List<Listing>
        {
            new Listing("1", "The A-Frame in Mraza"),
            new Listing("2", "Qo'noS Mountaintop Cabin"),
            new Listing("3", "Interstellar cottage in Vaperi III")
        };
    }
}
