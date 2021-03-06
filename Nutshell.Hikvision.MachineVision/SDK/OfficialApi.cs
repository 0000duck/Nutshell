﻿using System;
using System.Runtime.InteropServices;

namespace Nutshell.Hikvision.MachineVision.SDK
{
        public static class OfficialApi
        {
                #region 常量

                public const int MaxStreamChannelPacketSize = 10000;

                public const int MinStreamChannelPacketSize = 8000;

                public const int DefaultStreamChannelPacketSize = 8164;

                #endregion 常量

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_EnumDevices")]
                public static extern ErrorCode EnumDevices(DeviceType nTLayerType, ref DeviceInformationCollection deviceInfoCollection);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_IsDeviceAccessible")]
                public static extern bool IsDeviceAccessible(IntPtr handle, ref DeviceInformation pstDevInfo,
                        AccessMode accessMode);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_CreateHandle")]
                public static extern ErrorCode CreateHandle(ref IntPtr handle, ref DeviceInformation pstDevInfo);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_DestroyHandle")]
                public static extern ErrorCode DestroyHandle(IntPtr handle);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_OpenDevice")]
                public static extern ErrorCode OpenDevice(IntPtr handle, AccessMode accessMode, ushort switchoverKey = 0);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_CloseDevice")]
                public static extern ErrorCode CloseDevice(IntPtr handle);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_StartGrabbing")]
                public static extern ErrorCode StartGrabbing(IntPtr handle);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_StopGrabbing")]
                public static extern ErrorCode StopGrabbing(IntPtr handle);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_GetOneFrame")]
                public static extern ErrorCode GetOneFrame(IntPtr handle, IntPtr pData, int nDataSize,
                        ref FrameOutInformation pFrameInfo);

                #region 万能接口

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_GetIntValue")]
                public static extern ErrorCode GetIntValue(IntPtr handle, string command, ref Int32Value value);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_SetIntValue")]
                public static extern ErrorCode SetIntValue(IntPtr handle, string command, uint value);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_GetEnumValue")]
                public static extern ErrorCode GetEnumValue(IntPtr handle, string command, ref EnumValue value);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_SetEnumValue")]
                public static extern ErrorCode SetEnumValue(IntPtr handle, string command, uint value);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_SetCommandValue")]
                public static extern ErrorCode SetCommandValue(IntPtr handle, string command);

                #endregion 万能接口

                #region GIGE独有接口

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_GIGE_GetGevSCPSPacketSize")]
                internal static extern ErrorCode GetStreamChannelPacketSize(IntPtr handle, ref Int32Value value);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_GIGE_SetGevSCPSPacketSize")]
                internal static extern ErrorCode SetStreamChannelPacketSize(IntPtr handle, uint value);

                #endregion GIGE独有接口

                #region 异常处理

                public delegate void ExceptionCallbackFunction(ExceptionType exceptionType, IntPtr user);

                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_RegisterExceptionCallBack")]
                internal static extern bool RegisterExceptionCallBack(IntPtr handle,
                        ExceptionCallbackFunction callBack,
                        IntPtr user);

                #endregion 异常处理

                #region 寄存器读写

                /// <summary>
                /// 读取寄存器数据
                /// </summary>
                /// <param name="handle">设备句柄</param>
                /// <param name="buffer">缓冲区指针</param>
                /// <param name="address">寄存器地址</param>
                /// <param name="length">读取长度（字节）</param>
                /// <returns>错误码，成功返回MV_OK</returns>
                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_ReadMemory")]
                public static extern ErrorCode ReadMemory(IntPtr handle,
                        IntPtr buffer,
                        long address,
                        long length);

                /// <summary>
                /// 写入寄存器数据
                /// </summary>
                /// <param name="handle">设备句柄</param>
                /// <param name="buffer">缓冲区指针</param>
                /// <param name="address">寄存器地址</param>
                /// <param name="length">写入长度（字节）</param>
                /// <returns>错误码，成功返回MV_OK</returns>
                [DllImport(@"MvCameraControl.dll", EntryPoint = "MV_CC_WriteMemory")]
                public static extern ErrorCode WriteMemory(IntPtr handle,
                        IntPtr buffer,
                        long address,
                        long length);

                #endregion 寄存器读写
        }
}