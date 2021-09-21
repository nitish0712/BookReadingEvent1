using AutoMapper;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookReadingEvent1.Models;

namespace BookReadingEvent1.Helper
{
    public class CommentToCommentModelHelper
    {
        public CommentModel CommentToCommentModelMapping(Comment c)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Comment, CommentModel>();

            });
            IMapper iMapper = config.CreateMapper();
            var source = c;

            var destination = iMapper.Map<Comment, CommentModel>(source);
            return destination;
        }

        public IEnumerable<CommentModel> GetCommentModel(IEnumerable<Comment> comments)
        {
            List<CommentModel> commentModels = new List<CommentModel>();
            foreach(var item in comments)
            {
                commentModels.Add(CommentToCommentModelMapping(item));
            }
            return commentModels;
        }

    }
}