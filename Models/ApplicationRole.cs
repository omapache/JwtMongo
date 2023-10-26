using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace JwtMongo.Models;
[CollectionName("roles")]
public class ApplicationRole : MongoIdentityRole<Guid>
{
    
}
