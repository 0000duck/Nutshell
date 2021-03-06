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

using MongoDB.Bson.Serialization.Attributes;
using Nutshell.Aspects.Locations.Contracts;
using Nutshell.Data.Models;

namespace Nutshell.Data.Mongo.Models
{
        /// <summary>
        ///         Mongo数据模型接口
        /// </summary>
        public class MongoModel: IIdentityModel
        {
                /// <summary>
                /// 获取或设置标识
                /// </summary>
                /// <value>标识，不能为空引用或空字符串</value>
                [BsonId]
                [MustNotEqualNullOrEmpty]
                public string Id { get; set; }
        }
}