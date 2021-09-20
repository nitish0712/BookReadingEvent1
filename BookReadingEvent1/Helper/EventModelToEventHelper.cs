using AutoMapper;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Helper
{
    public class EventModelToEventHelper
    {
        public Event EventModelToEventMapping(EventModel e)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EventModel, Event>();
            });

            IMapper imapper = config.CreateMapper();

            var source = e;
            var destination = imapper.Map<EventModel, Event>(source);
            return destination;
        }

        public IEnumerable<Event> GetEvent(IEnumerable<EventModel> eventModels)
        {
            List<Event> events = new List<Event>();
            foreach (var item in eventModels)
            {
                events.Add(EventModelToEventMapping(item));
            }
            return events;

        }
    }
}
