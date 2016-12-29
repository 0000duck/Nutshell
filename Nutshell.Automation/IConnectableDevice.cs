﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2016-12-27
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2016-12-29
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************


using Nutshell.Automation.Models;
using Nutshell.Components;
using Nutshell.Components.Models;
using Nutshell.Data;

namespace Nutshell.Automation
{
        /// <summary>
        /// 可连接设备接口
        /// </summary>
        public interface IConnectableDevice : IDevice, IStorable<IConnectableDeviceModel>
        {
                /// <summary>
                /// 获取连接状态
                /// </summary>
                /// <value>连接状态</value>
                ConnectState ConnectState { get; }

                /// <summary>
                /// 获取连接调度者，连接调度者负责设备的连接\断开
                /// </summary>
                /// <value>连接调度者</value>
                IDispatcher ConnectDispatcher { get; }

                /// <summary>
                /// 在线测试
                /// </summary>
                /// <returns>设备在线返回True，否则返回False</returns>
                bool OnlineTest();

                /// <summary>
                /// 获取在线调度者,在线调度者负责检查设备在连接后是否依然在线
                /// </summary>
                /// <value>在线调度者</value>
                ILoopDispatcher OnlineDispatcher { get; }
        }
}
