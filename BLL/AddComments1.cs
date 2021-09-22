using Common;
using DAL;

namespace BusinessLayer
    {
    public class AddComments1
        {
            public void AddComment(Comment comment)
            {
            AddComments2 addComments = new AddComments2();
            addComments.AddComments(comment);
            }
        }
    }
