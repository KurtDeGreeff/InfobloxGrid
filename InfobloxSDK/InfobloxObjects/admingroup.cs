﻿using BAMCIS.Infoblox.Core;
using BAMCIS.Infoblox.Core.BaseObjects;
using BAMCIS.Infoblox.Core.Enums;
using System;
using System.Collections.Generic;

namespace BAMCIS.Infoblox.InfobloxObjects
{
    [Name("admingroup")]
    public class admingroup : BaseNameCommentObject
    {
        private List<string> _email_addresses;

        public AccessMethodEnum[] access_method { get; set; }
        public bool disable { get; set; }
        public string[] email_addresses 
        {
            get
            {
                return this._email_addresses.ToArray();
            }
            set
            {
                this._email_addresses = new List<string>();
                foreach (string email in value)
                {
                    string temp = String.Empty;
                    NetworkAddressTest.IsValidEmail(email, out temp, false, true);
                    this._email_addresses.Add(temp);
                }
            }
        }
        [SearchableAttribute(Equality = true)]
        public string[] roles { get; set; }
        [SearchableAttribute(Equality = true)]
        public bool superuser { get; set; }

        public admingroup(string name)
        {
            this.disable = false;
            this.name = name;
            this.superuser = false;
        }
    }
}
