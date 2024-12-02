namespace Odyssey.IntroHCListings.Types;

public class Mutation
{
    [GraphQLDescription("Creates a new listing.")]
    public CreateListingResponse CreateListing()
    {
        return new CreateListingResponse(
            200,
            true,
            "Successfully created listing.",
            new Listing("1", "The A-Frame in Mraza", "A very cozy space", null)
        );
    }
}
