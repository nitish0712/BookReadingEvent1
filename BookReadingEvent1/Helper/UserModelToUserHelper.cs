using AutoMapper;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Helper
{
    public class UserModelToUserHelper
    {
        public User UserModelToUserMapping(UserModel e)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<UserModel, User>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<UserModel, User>(source);
            return destination;
        }
    }
}