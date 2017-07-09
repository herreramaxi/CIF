using CIF.Common.API.Services;
using CIF.Model;
using CIF.Services;
using CIF.Common.API.Repositories;

namespace CIF.Service
{
    public class UserService : AbstractService<User>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}
