using System;
using System.Data;

namespace Prototype.Class
{

    /// <summary>
    /// Class structure for attendance model.
    /// </summary>
    class Attendance
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public string WorkId { get; set; }

        public string Position { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string PunchTime { get; set; }

        public string Result { get; set; }

        public string Location { get; set; }

        public string Note { get; set; }

        public string Image1 { get; set; }

        public string Image2 { get; set; }

        public string DeviceId { get; set; }

    }
}
