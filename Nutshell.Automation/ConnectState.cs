﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2014-10-24
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2014-10-24
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

namespace Nutshell.Automation
{
        /// <summary>
        ///         连接状态枚举
        /// </summary>
        public enum ConnectState
        {
                /// <summary>
                /// 已断开
                /// </summary>
                Disconnected = 0,

                /// <summary>
                /// 正在连接
                /// </summary>
                Connecting = 1,

                /// <summary>
                /// 已连接
                /// </summary>
                Connected = 2,

                /// <summary>
                /// 正在断开
                /// </summary>
                Disconnecting = 3
        }
}