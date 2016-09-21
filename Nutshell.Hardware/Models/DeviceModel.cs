﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2015-04-14
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2015-04-14
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************


using System.Xml.Serialization;
using Nutshell.Components.Models;

namespace Nutshell.Hardware.Models
{
        /// <summary>
        ///         设备数据模型
        /// </summary>
        [XmlType]
        public class DeviceModel : WorkerModel
        {
                public DeviceModel()
                {
                        NSRunMode = NSRunMode.Release;
                }

                /// <summary>
                ///         运行模式
                /// </summary>
                [XmlAttribute]
                public NSRunMode NSRunMode { get; set; }
        }
}