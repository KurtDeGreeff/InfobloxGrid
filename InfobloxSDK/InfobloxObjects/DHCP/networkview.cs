﻿using BAMCIS.Infoblox.Common;
using BAMCIS.Infoblox.Common.BaseObjects;
using BAMCIS.Infoblox.Common.Enums;
using BAMCIS.Infoblox.Common.InfobloxStructs;
using BAMCIS.Infoblox.Common.InfobloxStructs.Grid.CloudApi;

namespace BAMCIS.Infoblox.InfobloxObjects.DHCP
{
    [Name("networkview")]
    public class networkview : BaseNameCommentObject
    {
        public info cloud_info { get; set; }
        public dhcpddns[] ddns_zone_primaries { get; set; }
        [ReadOnlyAttribute]
        [SearchableAttribute(Equality = true)]
        public bool is_default { get; internal protected set; }

        public networkview(string name)
        {
            this.cloud_info = new info() { delegated_scope = CloudInfoDelegatedScopeEnum.NONE, owned_by_adaptor = false };
            this.ddns_zone_primaries = new dhcpddns[0];
            base.name = name;
        }
    }
}
