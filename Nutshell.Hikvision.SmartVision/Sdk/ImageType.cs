﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2017-11-23
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2017-11-23
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************
namespace Nutshell.Hikvision.SmartVision.Sdk
{
        /// <summary>
        /// 图像文件格式
        /// </summary>
        public enum ImageType
        {
                /// <summary>
                /// 未定义
                /// </summary>
                Undefined = 0,

                /// <summary>
                /// BMP位图格式
                /// </summary>
                Bmp = 1,

                /// <summary>
                /// JPG压缩格式
                /// </summary>
                Jpg = 2,

                /// <summary>
                /// 8位原始位图格式
                /// </summary>
                Mono8 = 3
        }
}