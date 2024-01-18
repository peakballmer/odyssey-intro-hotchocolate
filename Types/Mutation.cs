namespace Odyssey.MusicMatcher;

public class Mutation
{
    [GraphQLDescription("Add one or more items to a user's playlist.")]
    public AddItemsToPlaylistPayload AddItemsToPlaylist()
    {
        return new AddItemsToPlaylistPayload(
            200,
            true,
            "Successfully added items to playlist.",
            new Playlist("6Fl8d6KF0O4V5kFdbzalfW", "Sweet Beats & Eats")
        );
    }
}
