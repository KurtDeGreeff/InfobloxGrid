﻿using BAMCIS.Infoblox.Common.Enums;

namespace BAMCIS.Infoblox.Common.InfobloxStructs.Grid.CloudApi
{
    public class info
    {
        public dhcpmember delegated_member { get; set; }
        public string delegated_root { get; set; }
        public CloudInfoDelegatedScopeEnum delegated_scope { get; set; }
        public bool owned_by_adaptor { get; set; }
        public string tenant { get; set; }
        public CloudInfoUsageEnum usage { get; set; }
    }
}
