using DataLayer;
namespace BusinessLayer
    {
    public class UserRoles1
        {
        public string[] GetRoles(string userName)
            {
            return new UserRoles2().GetRoles(userName);
            }
        }
    }
