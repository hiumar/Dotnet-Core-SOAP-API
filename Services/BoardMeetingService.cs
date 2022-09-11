using PUCARS.API.Interfaces;
using PucarsServices.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCARS.API.Services
{
    public class BoardMeetingService : IBoardMeetingService
    {
        public List<GetAllBoardMeetings> GetAllBoardMeetings()
        {
            List<GetAllBoardMeetings> boardMeetings = new List<GetAllBoardMeetings>();
            GetAllBoardMeetings getAllBoardMeeting = new GetAllBoardMeetings()
            {
                AccountsEnded = "This id test",
                //ClosedForm =DateTime.U
                ClosedForm = new DateOnly(2022, 09, 09),
                HeldPalce="Lahore"


        };
            boardMeetings.Add(getAllBoardMeeting);

            return boardMeetings;
        }
    }
}
