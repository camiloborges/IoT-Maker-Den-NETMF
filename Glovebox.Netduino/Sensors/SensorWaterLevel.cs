using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;
using Glovebox.MicroFramework;
using Glovebox.MicroFramework.Base;

namespace Glovebox.Netduino.Sensors {
    public class SensorWaterLevel: Generic.SensorOneAnalogWire {

        public SensorWaterLevel(Cpu.AnalogChannel pin, int SampleRateMilliseconds, string name)
            : base(pin, SampleRateMilliseconds, name, "waterlevel", "p")
        {

        }

        
    }
}
