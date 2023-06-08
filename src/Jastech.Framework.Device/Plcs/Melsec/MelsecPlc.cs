﻿using Jastech.Framework.Comm;
using Jastech.Framework.Device.Plcs.Melsec.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jastech.Framework.Device.Plcs.Melsec
{
    public class MelsecPlc : Plc
    {
        public IComm Communition { get; set; } = null;

        public MelsecPlc(string name, IComm communication, IMelsecParser melsecParser)
            : base(name)
        {
            Communition = communication;
        }

        public override void Write(string address, byte[] value)
        {
            throw new NotImplementedException();
        }

        public override void Read(string address, int length)
        {
            throw new NotImplementedException();
        }

        public override void SendData(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
