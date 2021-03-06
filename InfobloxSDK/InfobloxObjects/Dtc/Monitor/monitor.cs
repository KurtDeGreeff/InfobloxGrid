﻿using BAMCIS.Infoblox.Core;
using BAMCIS.Infoblox.Core.BaseObjects;
using BAMCIS.Infoblox.Core.Enums;
using System;

namespace BAMCIS.Infoblox.InfobloxObjects.Dtc.Monitor
{
    [Name("dtc:monitor")]
    public class dtcmonitor : BaseMonitorClass
    {
        private uint _port;

        public string monitor { get; set; }

        public uint port
        {
            get
            {
                return this._port;
            }
            set
            {
                if (value >= 1 && value <= 65535)
                {
                    this._port = value;
                }
                else
                {
                    throw new ArgumentException("The port must be a valid integer between 1 and 65535.");
                }
            }
        }

        [Basic]
        public TransportTypeEnum type { get; set; }

        public dtcmonitor()
        {
            base.comment = String.Empty;
        }
    }
}
