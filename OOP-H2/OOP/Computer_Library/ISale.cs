using System;
using System.Collections.Generic;

namespace ArchiveOverComputerWebshopLibrary
{
    public interface ISale
    {
        public string GetSalesFeatures();

        public string GetDescription();

        public List<String> TargetAudience();
        
        
    }
}