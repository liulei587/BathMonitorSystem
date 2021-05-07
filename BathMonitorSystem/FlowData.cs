using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathMonitorSystem
{
    public class FlowData
    {
        //温度
        public float Temp { get; set; }
        //压力
        public float Pressure { get; set; }
        //实时流量
        public float FlowInstant { get; set; }
        //累计流量
        public float FlowTotal { get; set; }
    }
}
