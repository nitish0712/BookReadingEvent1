using AutoMapper;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Helper
{
    public class RegisterUserModelToUserHelper
    {
        public User RegisterUserModelToUserMapping(RegisterUser e)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<RegisterUser, User>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<RegisterUser, User>(source);
            return destination;
        }
    }
}