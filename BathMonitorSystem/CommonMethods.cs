using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathMonitorSystem
{
    public static class CommonMethods
    {
        private static Dictionary<int, FlowData> currentValue = new Dictionary<int, FlowData>();

        public static Dictionary<int, FlowData> CurrentValue
        {
            get
            {
                return currentValue;
            }

            set
            {
                currentValue = value;
            }
        }

        public static Dictionary<int, ModTCP> CurrentModbusList = new Dictionary<int, ModTCP>();
    }
}
