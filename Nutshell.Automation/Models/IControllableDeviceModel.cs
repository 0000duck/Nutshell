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

using Nutshell.Components.Models;

namespace Nutshell.Automation.Models
{
        /// <summary>
        ///         可控设备设备数据模型
        /// </summary>
        public interface IControllableDeviceModel : IDeviceModel
        {
                ControlMode ControlMode { get; set; }
        }
}