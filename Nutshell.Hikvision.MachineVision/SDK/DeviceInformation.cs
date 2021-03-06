﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2016-07-17
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2016-07-31
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************
using Nutshell.Net;
using System.Runtime.InteropServices;

namespace Nutshell.Hikvision.MachineVision.SDK
{
        /// <summary>
        /// 设备信息结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct DeviceInformation
        {
                /// <summary>
                /// 固件主版本号
                /// </summary>
                public ushort MajorVersion;

                /// <summary>
                /// 固件次版本号
                /// </summary>
                public ushort MinorVersion;

                /// <summary>
                /// MAC地址高32位
                /// </summary>
                public uint MacAddressHigh32Bit;

                /// <summary>
                /// MAC地址低32位
                /// </summary>
                public uint MacAddressLow32Bit;

                /// <summary>
                /// 设备类型(通过传输层协议区分)
                /// </summary>
                public DeviceType DeviceType;

                /// <summary>
                /// 保留
                /// </summary>
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
                public uint[] Reserved;

                /// <summary>
                /// 以太网摄像机独有设备信息
                /// </summary>
                public GigeDeviceInformation GigeDeviceInformation;

                public MacAddress GetMacAddress()
                {
                        return new MacAddress(MacAddressHigh32Bit, MacAddressLow32Bit);
                }
        }
}