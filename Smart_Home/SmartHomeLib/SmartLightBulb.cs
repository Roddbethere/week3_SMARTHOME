using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeLib
{
    internal class SmartLightBulb : SmartDevice
    {
        public SmartLightBulb(string deviceId, string name) : base(deviceId, name)
        {
        }
        public override string GetStatus()
        {
           return $"Smart Light Bulb '{Name}' (ID: {DeviceId}) is {(IsOnline ? "Online" : "Offline")} and {(IsPoweredOn ? "On" : "Off")}.";
        }
    }
}
