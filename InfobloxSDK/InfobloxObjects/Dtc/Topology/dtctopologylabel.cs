﻿using BAMCIS.Infoblox.Common;
using BAMCIS.Infoblox.Common.Enums;

namespace BAMCIS.Infoblox.InfobloxObjects.Dtc.Topology
{
    [Name("dtc:topology:label")]
    public class dtctopologylabel : RefObject
    {
        [ReadOnlyAttribute]
        [SearchableAttribute(Equality = true)]
        public DtcLabelFieldEnum field { get; internal protected set; }
        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true, Regex = true)]
        public string label { get; internal protected set; }
    }
}