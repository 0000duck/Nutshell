﻿// ***********************************************************************
// 作者           : 阿尔卑斯 shuaihong617@qq.com
// 创建           : 2017-07-21
//
// 编辑           : 阿尔卑斯 shuaihong617@qq.com
// 日期           : 2017-07-21
// 内容           : 创建文件
// ***********************************************************************
// Copyright (c) 果壳机动----有金属的地方就有果壳. All rights reserved.
// <summary>
// </summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using Nutshell.Aspects.Locations.Contracts;
using Nutshell.Aspects.Locations.Propertys;
using Nutshell.Extensions;

namespace Nutshell.Automation.BarcodeRecognition
{
        /// <summary>
        /// 条码扫描设备
        /// </summary>
        public class BarcodeRecognizerDevice : ConnectableDevice
        {
	        public BarcodeRecognizerDevice(string id = "")
			:base(id)
	        {
		        
	        }

                /// <summary>
                /// 条码
                /// </summary>
                private string _barcode = string.Empty;

                /// <summary>
                /// 获取或设置条码
                /// </summary>
                /// <value>条码</value>
                [MustNotEqualNull]
                public string Barcode
                {
                        get { return _barcode; }
                        private set
                        {
                                _barcode = value;
                                OnPropertyValueChanged();

                                HasBarcode = !Barcode.IsEmpty();

                                OnBarcodeReceived(new BarcodeEventArgs(_barcode));
                        }
                }

                [NotifyPropertyValueChanged]
                public bool HasBarcode { get; private set; }

                public void Reset()
	        {
		        WriteBarcode(String.Empty);
	        }

                public void WriteBarcode(string barcode)
                {
                        Barcode = barcode;
                }

                #region 事件

                /// <summary>
                ///         当条码接收成功时发生。
                /// </summary>
                [Description("条码接收成功事件")]
                //[LogEventInvokeHandler]
                public event EventHandler<BarcodeEventArgs> BarcodeReceived;

                /// <summary>
                /// 引发条码接收成功事件。
                /// </summary>
                /// <param name="e">包含事件数据的实例<see cref="EventArgs" /></param>
                protected virtual void OnBarcodeReceived(BarcodeEventArgs e)
                        => e.Raise(this, ref BarcodeReceived);

                #endregion
        }
}
