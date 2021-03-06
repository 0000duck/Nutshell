﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2015-01-05
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2015-01-05
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

using System.Xml.Serialization;
using Nutshell.Aspects.Locations.Contracts;
using Nutshell.Data.Models;

namespace Nutshell.RabbitMQ.Models
{
        /// <summary>
        ///         RabbitMQ队列数据模型
        /// </summary>
        [XmlType]
        public class RabbitMQQueueModel :IdentityModel
        {
                public RabbitMQQueueModel()
                {
                        
                }

                public RabbitMQQueueModel(string name,
                        bool isDurable = true, bool isExclusive = false, bool isAutoDelete = false)
                {
                        Name = name;
                        IsDurable = isDurable;
                        IsExclusive = isExclusive;
                        IsAutoDelete = isAutoDelete;
                }

                /// <summary>
                ///         获取或设置名称
                /// </summary>
                /// <value>名称</value>
                [MustNotEqualNullOrEmpty]
                [XmlAttribute]
                public string Name { get; set; }



                /// <summary>
                ///         获取或设置是否持久化
                /// </summary>
                /// <value>是否持久化</value>
                [XmlAttribute]
                public bool IsDurable { get; set; } = true;

                /// <summary>
                ///         获取或设置是否私有
                /// </summary>
                /// <value>是否私有</value>
                [XmlAttribute]
                public bool IsExclusive { get; set; } = false;

                /// <summary>
                ///         获取或设置是否自动删除
                /// </summary>
                /// <value>是否自动删除</value>
                [XmlAttribute]
                public bool IsAutoDelete { get; set; } = false;
        }
}