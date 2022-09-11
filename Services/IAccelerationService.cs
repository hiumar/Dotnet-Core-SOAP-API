using SOAPTest.Models;
using System.ServiceModel;

namespace SOAPTest.Services
{
    [ServiceContract]
    public interface IAccelerationService
    {
        [OperationContract]
        string Speed(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MachineModel TestMachine(MachineModel machine);
    }
}
