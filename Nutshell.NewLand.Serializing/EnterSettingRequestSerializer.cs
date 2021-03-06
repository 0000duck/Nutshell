﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using Nutshell.NewLand.Messaging;
using Nutshell.Serializing.Binary;

namespace Nutshell.NewLand.Serializing
{
        public class EnterSettingRequestSerializer : BinarySerializer<EnterSettingRequestMessage>
        {
                public override byte[] Serialize(EnterSettingRequestMessage t)
                {
                        return Encoding.ASCII.GetBytes("$$$$");
                }

                public override EnterSettingRequestMessage Deserialize(byte[] content)
                {
                        Trace.Assert(content.Length == 4);
                        foreach (var b in content)
                        {
                                Trace.Assert(b == '$');
                        }

                        return new EnterSettingRequestMessage();
                }
        }
}
