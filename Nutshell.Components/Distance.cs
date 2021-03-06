﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2017-04-22
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2017-05-02
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳.. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

using System.Diagnostics;
using Nutshell.Components.Models;
using Nutshell.Data.Models;
using Nutshell.Storaging;

namespace Nutshell.Components
{
        /// <summary>
        /// 限位
        /// </summary>
        public class Distance:StorableObject
        {
                /// <summary>
                /// 获取精度
                /// </summary>
                /// <value>精度</value>
                public float Accuracy { get; private set; }

                /// <summary>
                /// 获取标准值
                /// </summary>
                /// <value>标准值</value>
                public float Standard { get; private set; }

                /// <summary>
                /// 获取修正值
                /// </summary>
                /// <value>修正值</value>
		public float Addition { get; set; }

                /// <summary>
                /// 获取实际值
                /// </summary>
                /// <value>实际值</value>
                public float Parctice => Standard + Addition;



                public override void Load(IIdentityModel model)
                {
                        base.Load(model);

                        var subModel = model as DistanceModel;
                        Trace.Assert(subModel != null);

                        Accuracy = subModel.Accuracy;
                        Standard = subModel.Standard;
                }

                /// <summary>
                /// 保存数据到数据模型
                /// </summary>
                /// <param name="model">写入数据的目的数据模型，该数据模型不能为空引用</param>
                /// <exception cref="System.NotImplementedException"></exception>
                public void Save(DistanceModel model)
		{
			throw new System.NotImplementedException();
		}

                

	        
        }
}
