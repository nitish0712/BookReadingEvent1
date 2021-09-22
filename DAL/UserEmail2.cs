using System.Linq;
namespace DataLayer
    {
    public class UserEmail2
        {
           public string GetUserEmail(string userName)
            {
           
                using (BookReadingContext context = new BookReadingContext())
                    {
                       string userEmail= (from u in context.Users
                                                         where u.UserName == userName
                                                         select u.EmailId).ToList().First();
                    return userEmail;

                    }
                
            }
           
        }
    }
