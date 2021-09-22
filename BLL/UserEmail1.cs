using DAL;

namespace BusinessLayer
    {
   public class UserEmail1
        {
            public string GetUserEmail(string userName)
            {
            
                return new UserEmail2().GetUserEmail(userName);
                
            }
        }
    }
