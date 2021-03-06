﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2014-11-08
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2014-11-08
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************


using System.Collections.Generic;
using System.Xml.Serialization;
using Nutshell.Messaging.Models;

namespace Nutshell.RabbitMQ.Messaging.Models
{
        /// <summary>
        ///         多值消息数据模型
        /// </summary>
        
        public class RabbitMQMultiValueMessage<T> : RabbitMQMessage
        {
                public RabbitMQMultiValueMessage()
                        :this(null)
                {
                }

                public RabbitMQMultiValueMessage(params T[] objs)
                {
                        Values = new List<T>();
                        if (objs != null)
                        {
                                foreach (var obj in objs)
                                {
                                        Values.Add(obj);
                                }
                        }
                }
                        
                [XmlArray]
                public List<T> Values { get; set; }

                public void Add(T t)
                {
                        Values.Add(t);
                }
        }

	
}