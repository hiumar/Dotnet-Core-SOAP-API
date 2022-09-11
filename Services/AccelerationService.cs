using SOAPTest.Models;
using System;
using System.Xml.Linq;

namespace SOAPTest.Services
{
    public class AccelerationService : IAccelerationService
    {
        public string Speed(string s)
        {
            Console.WriteLine(s + " MPH");
            return s+ "MPH";
        }

        public MachineModel TestMachine(MachineModel machine)
        {
            return machine;
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}
