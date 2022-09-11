using PucarsServices.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace PUCARS.API.Interfaces
{
    [ServiceContract]
    public interface IBoardMeetingService
    {
        [OperationContract]
        List<GetAllBoardMeetings> GetAllBoardMeetings();
    }
}
