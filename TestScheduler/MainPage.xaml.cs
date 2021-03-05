using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfSchedule.XForms;
using TestScheduler.VM;
using Xamarin.Forms;

namespace TestScheduler
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        protected override void OnAppearing()
        {

            var mapping = new ScheduleAppointmentMapping();

            mapping.SubjectMapping = nameof(CEvent.Subject);
            mapping.StartTimeMapping = nameof(CEvent.FromDate);
            mapping.EndTimeMapping = nameof(CEvent.ToDate);
            mapping.ColorMapping = nameof(CEvent.EventColor);


            scheduler.AppointmentMapping = mapping;

            var vm = new EventsVM();
            scheduler.BindingContext = vm;

            scheduler.DataSource = vm.appointments;

            scheduler.ScheduleView = ScheduleView.MonthView;
            scheduler.MonthViewSettings.ShowAgendaView = true;

            base.OnAppearing();
        }
    }
}
