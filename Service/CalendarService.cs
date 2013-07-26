using System;
using System.Collections.Generic;
using System.Linq;
using Google.GData.Calendar;
using ThreePeaksMvc.Models;

namespace ThreePeaksMvc.Service
{
    public class CalendarService
    {

        public IList<CalendarItem> GetAllEvents()
        {
            var query = new EventQuery { Uri = new Uri("http://www.google.com/calendar/feeds/WestHill3Peaks@gmail.com/private/full") };

            return (from i in CreateCalendarService().Query(query).Entries
                       select new CalendarItem
                       {
                           Date = ((EventEntry)i).Times.First().StartTime,
                           Title = i.Title.Text
                       }).ToList();
        }

        public IList<CalendarItem> GetFutureEvents(int maxNumberOfEventsToReturn)
        {
            var query = new EventQuery
                            {
                                Uri = new Uri("http://www.google.com/calendar/feeds/WestHill3Peaks@gmail.com/private/full"),
                                StartTime = DateTime.Now
                            };

            return (from i in CreateCalendarService().Query(query).Entries
                       orderby ((EventEntry) i).Times.First().StartTime  
                       select new CalendarItem
                       {
                           Date = ((EventEntry)i).Times.First().StartTime,
                           Title = i.Title.Text
                       }).Take(maxNumberOfEventsToReturn).ToList();
        }


        private static Google.GData.Calendar.CalendarService CreateCalendarService()
        {
            var calendar = new Google.GData.Calendar.CalendarService("WestHill3Peaks");
            calendar.setUserCredentials("WestHill3Peaks@gmail.com", "3PWestHill24");
            return calendar;
        }
    }
}