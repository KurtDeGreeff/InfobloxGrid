﻿using BAMCIS.Infoblox.Common;

namespace BAMCIS.Infoblox.InfobloxObjects.Grid.CloudApi
{
    [Name("grid:cloudapi:cloudstatistics")]
    public class cloudstatistics : RefObject
    {
        [ReadOnlyAttribute]
        public uint allocated_available_ratio { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint allocated_ip_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public string available_ip_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint fixed_ip_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint floating_ip_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint tenant_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint tenant_ip_count { get; internal protected set; }
        [ReadOnlyAttribute]
        public uint tenant_vm_count { get; internal protected set; }
    }
}