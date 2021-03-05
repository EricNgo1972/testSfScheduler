using System;
using System.Collections.ObjectModel;

namespace TestScheduler.VM
{
    public class EventsVM
    {
        public EventsVM()
        {
            appointments = new ObservableCollection<CEvent>();

            appointments.Add(new CEvent() { Subject = "Meeting", FromDate = DateTime.Now.AddHours(-3), ToDate = DateTime.Now.AddHours(-2), EventColor = Color.Aqua });

            appointments.Add(new CEvent() { Subject = "Oppening", FromDate = DateTime.Now.AddHours(-3).AddDays(1), ToDate = DateTime.Now.AddHours(-2).AddDays(1), EventColor = Color.Orange });
        }

        public ObservableCollection<CEvent> appointments { get; set; }

    }

    public class CEvent
    {
        public string Subject { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }


        public Xamarin.Forms.Color EventColor { get; set; }

        //thow exception
        //public System.Drawing.Color EventColor { get; set; }
    }
}
