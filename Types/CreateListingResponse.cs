namespace Odyssey.IntroHCListings.Types;

public class CreateListingResponse
{
    [GraphQLDescription("Similar to HTTP status code, represents the status of the mutation.")]
    public int Code { get; set; }

    [GraphQLDescription("Indicates whether the mutation was successful.")]
    public bool Success { get; set; }

    [GraphQLDescription("Human-readable message for the UI.")]
    public string Message { get; set; }

    [GraphQLDescription("The newly-created listing.")]
    public Listing? Listing { get; set; }

    public CreateListingResponse(int code, bool success, string message, Listing? listing)
    {
        Code = code;
        Success = success;
        Message = message;

        if (listing != null)
        {
            Listing = listing;
        }
    }
}
