﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2017-11-22
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2017-11-23
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

using System.Runtime.InteropServices;

namespace Nutshell.Hikvision.SmartVision.Sdk
{
        /// <summary>
        ///         设备信息集合
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct DeviceInformationCollection
        {
                /// <summary>
                ///         在线设备数量
                /// </summary>
                public uint OnlineDevicesCount;

                /// <summary>
                ///         设备信息数组
                /// </summary>
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)] public DeviceInfomation[] DeviceInfomations;
        }
}