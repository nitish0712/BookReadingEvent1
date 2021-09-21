using AutoMapper;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Helper
{
    public class CommentModelToCommentHelper
    {
        public Comment CommentModelToCommentMapping(CommentModel cm)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommentModel, Comment>();
            });
            IMapper imapper = config.CreateMapper();

            var source = cm;
            var destination = imapper.Map<CommentModel, Comment>(source);
            return destination;
        }
    }
}