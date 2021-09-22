using Common;
namespace DAL
    {
    public  class AddComments2
        {

           public void AddComments(Comment comment)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                context.Comments.Add(comment);
                context.SaveChanges();
                }
            }
        }
    }
