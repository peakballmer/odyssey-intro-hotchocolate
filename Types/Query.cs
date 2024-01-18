using SpotifyWeb;

namespace Odyssey.MusicMatcher;

public class Query
{
    [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
    public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
    {
        var response = await spotifyService.GetFeaturedPlaylistsAsync();
        return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
    }
}
