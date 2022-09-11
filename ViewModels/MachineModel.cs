using System.Runtime.Serialization;

namespace SOAPTest.Models
{
    [DataContract]
    public class MachineModel
    {
      
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string? MachineName { get; set; }
            [DataMember]
            public string? HorsePower { get; set; }
        
    }
}
