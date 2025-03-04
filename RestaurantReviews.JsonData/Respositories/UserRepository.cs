using RestaurantReviews.Interfaces.Models;
using RestaurantReviews.Interfaces.Repositories;
using System.Linq;

namespace RestaurantReviews.JsonData.Repositories
{
    public class UserRepository : RepositoryBase<IUser>, IUserRepository
    {
        public UserRepository(IContext context) : base(context) { }

        public override IDataSet<IUser> GetDataSet()
        {
            return context.UserDataSet;
        }

        public override void Update(long id, IUser q)
        {
            var contents = GetAll();
            var found = contents.FirstOrDefault(x => x.Id == id);
            if (found == null)
                return;
            // no properties to update
            context.UserDataSet.Save(contents);
        }
    }
}