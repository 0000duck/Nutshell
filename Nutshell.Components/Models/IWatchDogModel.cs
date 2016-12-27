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


namespace Nutshell.Components.Models
{
        /// <summary>
        ///         看门狗序列化数据模型
        /// </summary>
        public interface IWatchDogModel : IWorkerModel
        {
                /// <summary>
                ///         溢出时间间隔, 单位毫秒
                /// </summary>
                int Interval { get; set; }
        }
}