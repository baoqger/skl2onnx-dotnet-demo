using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadScoringONNXFunc
{
    internal class LeadModelParameters
    {
       public float DoNotEmail { get; set; }
       public float TotalVisits { get; set; }
       public float PageViewsPerVisit { get; set; }
       public float LeadOriginLandingPageSubmission { get; set; }
       public float LeadOriginLeadImport { get; set; }
       public float LeadSourceReference { get; set; }
       public float LeadSourceReferralSites { get; set; }
       public float LeadSourceWelingakWebsite { get; set; }
       public float LastActivityEmailBounced { get; set; }
       public float LastActivityEmailLinkClicked { get; set; }
       public float LastActivityEmailOpened { get; set; }
       public float LastActivityOlarkChatConversation { get; set; }
       public float LastActivityOtherActivity { get; set; }
       public float LastActivitySMSSent { get; set; }
       public float SpecializationHealthcareManagement { get; set; }
       public float SpecializationITProjectsManagement { get; set; }
       public float SpecializationMarketingManagement { get; set; }
       public float SpecializationOthers { get; set; }
       public float SpecializationSupplyChainManagement { get; set; }
       public float SpecializationTravelAndTourism { get; set; }
       public float WhatIsYourCurrentOccupationStudent { get; set; }
       public float WhatIsYourCurrentOccupationWorkingProfessional { get; set; }
    }
}
