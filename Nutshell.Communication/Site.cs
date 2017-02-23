﻿using System;
using Nutshell.Aspects.Locations.Contracts;
using Nutshell.Components;
using Nutshell.Messaging;
using Nutshell.Serializing;
using PostSharp.Patterns.Model;
using PostSharp.Serialization;

namespace Nutshell.Communication
{
        /// <summary>
        /// 通讯上下文接口
        /// </summary>
        public sealed class Site:Worker,ISite
        {
                public Site(string id = null) 
                        : base( id)
                {
                }

		/// <summary>
		/// 获取或设置发送者
		/// </summary>
		/// <value>发送者</value>
		[MustNotEqualNull]
	        public ISender Sender { get; set; }

	        public void Send([MustNotEqualNull]byte[] data)
	        {
		        if (Sender == null)
		        {
			        throw new InvalidOperationException();
		        }
		        Sender.Send(data);
	        }


		public event EventHandler<EventArgs> SendSuccessed;
	        public event EventHandler<EventArgs> SendFailed;

		[MustNotEqualNull]
	        public IReceiver Receiver { get; set; }

	        public event EventHandler<ValueEventArgs<byte[]>> ReceiveSuccessed;


                protected override IResult Starup(IRunableObject runableObject)
                {
                        throw new NotImplementedException();
                }

                protected override IResult Clean(IRunableObject runableObject)
                {
                        throw new NotImplementedException();
                }
        }
}
