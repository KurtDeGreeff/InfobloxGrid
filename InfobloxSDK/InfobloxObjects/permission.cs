﻿using BAMCIS.Infoblox.Core;
using BAMCIS.Infoblox.Core.Enums;

namespace BAMCIS.Infoblox.InfobloxObjects
{
    [Name("permission")]
    public class ibxpermission
    {
        [SearchableAttribute(Equality = true)]
        [Basic]
        public string group { get; set; }

        [SearchableAttribute(Equality = true)]
        public string @object { get; set; }

        [Required]
        [SearchableAttribute(Equality = true)]
        [Basic]
        public DenyReadWriteEnum permission { get; set; }

        [SearchableAttribute(Equality = true)]
        [Basic]
        public InfobloxResourceTypeEnum resource_type { get; set; }

        [SearchableAttribute(Equality = true)]
        [Basic]
        public string role { get; set; }

        public ibxpermission(string group, DenyReadWriteEnum permission, string @object)
        {
            this.group = group;
            this.permission = permission;
            this.@object = @object;
        }

        public ibxpermission(string group, DenyReadWriteEnum permission, InfobloxResourceTypeEnum resource_type)
        {
            this.group = group;
            this.permission = permission;
            this.resource_type = resource_type;
        }

        public ibxpermission(DenyReadWriteEnum permission, InfobloxResourceTypeEnum resource_type, string role)
        {
            this.permission = permission;
            this.resource_type = resource_type;
            this.role = role;
        }

        public ibxpermission(DenyReadWriteEnum permission, string @object, string role)
        {
            this.@object = @object;
            this.permission = permission;
            this.role = role;
        }
    }
}
