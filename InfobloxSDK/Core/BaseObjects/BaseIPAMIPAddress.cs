﻿using BAMCIS.Infoblox.Core.Enums;

namespace BAMCIS.Infoblox.Core.BaseObjects
{
    public class BaseIPAMIPAddress : RefObject
    {
        private string _reserved_port;

        [ReadOnlyAttribute]
        public ConflictTypeEnum[] conflict_types { get; internal protected set; }

        [ReadOnlyAttribute]
        public DiscoverNowStatusEnum discover_now_status { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true, Regex = true)]
        public string fingerprint { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(Equality = true)]
        [Basic]
        public bool is_conflict { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true)]
        [Basic]
        public string lease_state { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true, Regex = true)]
        [Basic]
        public string[] names { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(Equality = true)]
        [Basic]
        public string network_view { get; internal protected set; }

        [ReadOnlyAttribute]
        [Basic]
        public string objects { get; internal protected set; }

        [ReadOnlyAttribute]
        public string reserved_port
        {
            get
            {
                return this._reserved_port;
            }
            internal protected set
            {
                this._reserved_port = value.TrimValue();
            }
        }

        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true)]
        [Basic]
        public string[] types { get; internal protected set; }

        [ReadOnlyAttribute]
        [SearchableAttribute(CaseInsensitive = true, Equality = true)]
        [Basic]
        public string[] usage { get; internal protected set; }
    }
}
