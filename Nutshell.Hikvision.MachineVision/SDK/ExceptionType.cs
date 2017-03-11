﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2016-07-17
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2016-07-17
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************
namespace Nutshell.Hikvision.MachineVision.SDK
{
        /// <summary>
        /// 异常类型枚举
        /// </summary>
        public enum ExceptionType : uint
        {
                /// <summary>
                /// 以太网设备断开连接
                /// </summary>
                以太网设备断开连接 = 0x00008001,
                /// <summary>
                /// 开发包与驱动版本不匹配
                /// </summary>
                开发包与驱动版本不匹配 = 0x00008002,
        }
}