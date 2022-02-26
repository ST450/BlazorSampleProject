using System;
using System.Collections.Generic;

namespace BlazorSampleProject.Models
{
    public partial class Weather
    {
        public long AreaId { get; set; }
        public byte[] DataDate { get; set; } = null!;
        public long Condition { get; set; }
        public double Tempreture { get; set; }
    }
}
