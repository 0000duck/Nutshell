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

using Nutshell.Communication.Models;
using Nutshell.MessageQueue.RabbitMQ.Models;
using Nutshell.RabbitMQ.Models;

namespace Nutshell.RabbitMQ.Xml
{
        /// <summary>
        ///         数据模型接口
        /// </summary>
        public interface IRabbitMQActorModel:IActorModel
        {
                IRabbitMQAuthenticationModel RabbitMQAuthenticationModel { get; set; }

		IRabbitMQExchangeModel RabbitMQExchangeModel { get; set; }
        }
}