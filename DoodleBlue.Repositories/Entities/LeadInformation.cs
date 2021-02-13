using System;
using System.Collections.Generic;
using System.Text;

namespace DoodleBlue.Repositories.Entities
{
    public class LeadInformation
    {
        public int LeadId { get; set; }
        public int LoanAmountRequires { get; set; }
        public int LeadSourceId { get; set; }
        public string CommunicationMode { get; set; }
        public int CurrentStatusId { get; set; }
        public int ContactDetailsId { get; set; }

    }
}
