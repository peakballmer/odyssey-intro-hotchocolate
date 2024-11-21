namespace Odyssey.IntroHCListings.Types;

public class Amenity
{
    [GraphQLDescription("The amenity ID")]
    public string Id { get; }

    [GraphQLDescription("The amenity category the amenity belongs to")]
    public string Category { get; set; }

    [GraphQLDescription("The amenity's name")]
    public string Name { get; set; }

    public Amenity(string id, string category, string name)
    {
        Id = id;
        Category = category;
        Name = name;
    }

    public Amenity(ListingsDataSource.Amenity obj)
    {
        Id = obj.Id;
        Category = obj.Category;
        Name = obj.Name;
    }
}
