/***************************************************************************************************
* 
* ��Ȩ��Ϣ����Ȩ���� (c) 2015, ���ݺ����������ּ����ɷ����޹�˾, ��������Ȩ��
* 
* �ļ����ƣ�MvCameraControl.h
* ժ    Ҫ���������SDK��C�ӿ���
*
* ��ǰ�汾��1.0.0.0
* ��    �ߣ��Ž���
* ��    �ڣ�2015-01-28
* ��    ע�����Բ����ڲ����ŵĽӿڶ���
***************************************************************************************************/
#ifndef _MV_CAMERA_CTRL_EX_H_
#define _MV_CAMERA_CTRL_EX_H_

#include "MvCameraControl.h"

#ifdef __cplusplus
extern "C" {
#endif 

//������Ϣ
MV_CAMCTRL_API int __stdcall MV_CC_ReadDebugInfo(void* handle, int nMsgType, char* pBuffer, unsigned int nSize);
MV_CAMCTRL_API int __stdcall MV_CC_WriteDebugInfo(void* handle, int nMsgType, char* pBuffer, unsigned int nLen);
MV_CAMCTRL_API int __stdcall MV_CC_OpenDeviceForUpgrade(IN void* handle,
                                              IN unsigned int nAccessMode = MV_ACCESS_Exclusive, 
                                              IN unsigned short nSwitchoverKey = 0);


MV_CAMCTRL_API int __stdcall MV_CC_SetWaterMarkEnable(bool bEnable = true);

MV_CAMCTRL_API int __stdcall MV_CC_IsDriverWorking(void* handle);

// 0����������1������
MV_CAMCTRL_API int __stdcall MV_CC_SetThrowAbnormalImage(void * handle, int bThrow);

#ifdef __cplusplus
}
#endif 

#endif //_MV_CAMERA_CTRL_EX_H_
