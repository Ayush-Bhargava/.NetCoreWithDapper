using System;
using System.Collections.Generic;
using System.Text;

namespace DoodleBlue.Contracts.Response
{
   public class LeadInformationResponse
    {
        public int LeadId { get; set; }
        public int LoanAmountRequires { get; set; }
        public int LeadSourceId { get; set; }
        public string CommunicationMode { get; set; }
        public int CurrentStatusId { get; set; }
        public int ContactDetailsId { get; set; }
    }
}
