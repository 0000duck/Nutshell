﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2015-09-05
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2015-09-05
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Threading;
using Nutshell.Components.Models;
using Nutshell.Data.Models;
using Nutshell.Log;

namespace Nutshell.Components
{
        /// <summary>
        ///         异步工作者
        /// </summary>
        public class Asyncer : Worker
        {
                public Asyncer(IdentityObject parent, string id = "", ThreadPriority priority = ThreadPriority.Normal, Action action = null)
                        : base(parent, id)
                {
                        if (action == null)
                        {
                                throw new ArgumentException("线程工作方法不能为null");
                        }

                        _thread = new Thread(() => action()) {Priority = priority};
                }

                #region 字段

                private readonly Thread _thread;

                #endregion

                public bool IsBusy
                {
                        get { return _thread.IsAlive; }
                }

                public override void Load(IStorableModel model)
                {
                        model.MustNotNull();
                        

                        base.Load(model);

                        var looperModel = model as LooperModel;
                        Trace.Assert(looperModel != null);

                        Trace.Assert(looperModel.Interval > 0);
                }

                protected override bool StartCore()
                {
                        if (_thread.IsAlive)
                        {
                                return true;
                        }
                        _thread.Start();
                        return true;
                }

                

                protected override bool StopCore()
                {
                        return true;
                }
        }
}