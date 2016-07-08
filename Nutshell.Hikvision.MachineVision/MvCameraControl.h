/***************************************************************************************************
* 
* ��Ȩ��Ϣ����Ȩ���� (c) 2015, ���ݺ����������ּ����ɷ����޹�˾, ��������Ȩ��
* 
* �ļ����ƣ�MvCameraControl.h
* ժ    Ҫ���������SDK��C�ӿ���
*
* ��ǰ�汾��1.0.0.0
* ��    �ߣ�������
* ��    �ڣ�2015-01-28
* ��    ע���½�
***************************************************************************************************/
#ifndef _MV_CAMERA_CTRL_H_
#define _MV_CAMERA_CTRL_H_

#include "MvErrorDefine.h"
#include "CameraParams.h"

/**
*  @brief  ��̬�⵼�뵼������
*/
#ifndef MV_CAMCTRL_API

    #ifdef WIN32
        #if defined(MV_CAMCTRL_EXPORTS)
            #define MV_CAMCTRL_API __declspec(dllexport)
        #else
            #define MV_CAMCTRL_API __declspec(dllimport)
        #endif
    #else
        #ifndef __stdcall
            #define __stdcall
        #endif

        #ifndef MV_CAMCTRL_API
            #define  MV_CAMCTRL_API
        #endif
    #endif

#endif

#ifndef IN
    #define IN
#endif

#ifndef OUT
    #define OUT
#endif

#ifdef __cplusplus
extern "C" {
#endif 

/************************************************************************/
/* ����Ļ���ָ��Ͳ���                                                 */
/************************************************************************/

MV_CAMCTRL_API unsigned int __stdcall MV_CC_GetSDKVersion();
MV_CAMCTRL_API int __stdcall MV_CC_EnumerateTls();
MV_CAMCTRL_API int __stdcall MV_CC_EnumDevices(IN unsigned int nTLayerType, IN OUT MV_CC_DEVICE_INFO_LIST* pstDevList);
MV_CAMCTRL_API int __stdcall MV_CC_CreateHandle(OUT void ** handle, IN const MV_CC_DEVICE_INFO* pstDevInfo);
MV_CAMCTRL_API int __stdcall MV_CC_DestroyHandle(IN void * handle);
// �ݲ�֧��
MV_CAMCTRL_API bool __stdcall MV_CC_IsDeviceAccessible(IN void * handle, IN MV_CC_DEVICE_INFO* pstDevInfo, IN unsigned int nAccessMode);
MV_CAMCTRL_API int __stdcall MV_CC_OpenDevice(IN void* handle,
                                              IN unsigned int nAccessMode = MV_ACCESS_Exclusive, 
                                              IN unsigned short nSwitchoverKey = 0);
MV_CAMCTRL_API int __stdcall MV_CC_CloseDevice(IN void* handle);
// ע��ͼ�����ݻص����ݲ�֧��
MV_CAMCTRL_API int __stdcall MV_CC_RegisterImageCallBack(void* handle, 
                                                         void(__stdcall* cbOutput)(unsigned char * pData, MV_FRAME_OUT_INFO* pFrameInfo, void* pUser),
                                                         void* pUser);
MV_CAMCTRL_API int __stdcall MV_CC_StartGrabbing(IN void* handle);
MV_CAMCTRL_API int __stdcall MV_CC_StopGrabbing(IN void* handle);
MV_CAMCTRL_API int __stdcall MV_CC_GetOneFrame(IN void* handle, IN OUT unsigned char * pData , IN unsigned int nDataSize, IN OUT MV_FRAME_OUT_INFO* pFrameInfo);
// ��ʾһ֡ͼ��
MV_CAMCTRL_API int __stdcall MV_CC_Display(IN void* handle, void* hWnd);


/************************************************************************/
/* XML������������                                                         */
/************************************************************************/

MV_CAMCTRL_API int __stdcall MV_XML_GetGenICamXML(IN void* handle, IN OUT unsigned char* pData, IN unsigned int nDataSize, OUT unsigned int* pnDataLen);

// ��ȡ���ڵ�
MV_CAMCTRL_API int __stdcall MV_XML_GetRootNode(IN void* handle, IN OUT MV_XML_NODE_FEATURE* pstNode);

// ��xml�л�ȡָ���ڵ�������ӽڵ㣬���ڵ�ΪRoot
MV_CAMCTRL_API int __stdcall MV_XML_GetChildren(IN void* handle, IN MV_XML_NODE_FEATURE* pstNode, IN OUT MV_XML_NODES_LIST* pstNodesList);

//��õ�ǰ�ڵ������
MV_CAMCTRL_API int __stdcall MV_XML_GetNodeFeature(IN void* handle, IN MV_XML_NODE_FEATURE* pstNode, IN OUT void* pstFeature);

// pstFeature ����ṹ�����ݲο� MV_XML_FEATURE_x
MV_CAMCTRL_API int __stdcall MV_XML_UpdateNodeFeature(IN void* handle, IN MV_XML_InterfaceType enType, IN void* pstFeature);

// �нڵ���Ҫ����ʱ�Ļص�����
MV_CAMCTRL_API int __stdcall MV_XML_RegisterUpdateCallBack(IN void* handle, 
                                                           IN void(__stdcall* cbUpdate)(MV_XML_InterfaceType enType, void* pstFeature, MV_XML_NODES_LIST* pstNodesList, void* pUser),
                                                           IN void* pUser);


/************************************************************************/
/* ���������ȡ������                                                   */
/************************************************************************/

// ��ȡ������ͼ����
MV_CAMCTRL_API int __stdcall MV_CC_GetWidth(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetWidth(IN void* handle, IN const unsigned int nValue);

// ��ȡ������ͼ��߶�
MV_CAMCTRL_API int __stdcall MV_CC_GetHeight(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetHeight(IN void* handle, IN const unsigned int nValue);

// ��ȡ������AOI��ƫ��
MV_CAMCTRL_API int __stdcall MV_CC_GetAOIoffsetX(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetAOIoffsetX(IN void* handle, IN const unsigned int nValue);

// ��ȡ������AOI��ƫ��
MV_CAMCTRL_API int __stdcall MV_CC_GetAOIoffsetY(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetAOIoffsetY(IN void* handle, IN const unsigned int nValue);

// �����Զ��ع�ֵ����
MV_CAMCTRL_API int __stdcall MV_CC_GetAutoExposureTimeLower(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetAutoExposureTimeLower(IN void* handle, IN const unsigned int nValue);

//�����Զ��ع�ֵ����
MV_CAMCTRL_API int __stdcall MV_CC_GetAutoExposureTimeUpper(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetAutoExposureTimeUpper(IN void* handle, IN const unsigned int nValue);

// �����ȵ���
MV_CAMCTRL_API int __stdcall MV_CC_GetBrightness(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetBrightness(IN void* handle, IN const unsigned int nValue);

// ��ȡ������֡��
MV_CAMCTRL_API int __stdcall MV_CC_GetFrameRate(IN void* handle, IN OUT MVCC_FLOATVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetFrameRate(IN void* handle, IN const float fValue);

// ��������ֵ
MV_CAMCTRL_API int __stdcall MV_CC_GetGain(IN void* handle, IN OUT MVCC_FLOATVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetGain(IN void* handle, IN const float fValue);

// ������ǰ�ع�ֵ
MV_CAMCTRL_API int __stdcall MV_CC_GetExposureTime(IN void* handle, IN OUT MVCC_FLOATVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetExposureTime(IN void* handle, IN const float fValue);

// ��ȡ���������ظ�ʽ
MV_CAMCTRL_API int __stdcall MV_CC_GetPixelFormat(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetPixelFormat(IN void* handle, IN const unsigned int nValue);

// �ɼ�ģʽ
MV_CAMCTRL_API int __stdcall MV_CC_GetAcquisitionMode(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetAcquisitionMode(IN void* handle, IN const unsigned int nValue);


// ����ģʽ
MV_CAMCTRL_API int __stdcall MV_CC_GetGainMode(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetGainMode(IN void* handle, IN const unsigned int nValue);

// �Զ��ع�ģʽ
MV_CAMCTRL_API int __stdcall MV_CC_GetExposureAutoMode(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetExposureAutoMode(IN void* handle, IN const unsigned int nValue);

// ����ģʽ
MV_CAMCTRL_API int __stdcall MV_CC_GetTriggerMode(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetTriggerMode(IN void* handle, IN const unsigned int nValue);


// ������ʱ
MV_CAMCTRL_API int __stdcall MV_CC_GetTriggerDelay(IN void* handle, IN OUT MVCC_FLOATVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetTriggerDelay(IN void* handle, IN const float fValue);

// ����Դ
MV_CAMCTRL_API int __stdcall MV_CC_GetTriggerSource(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetTriggerSource(IN void* handle, IN const unsigned int nValue);

// ����һ�Σ��ӿڽ�����ѡ��Ĵ���ԴΪ�������ʱ��Ч��
MV_CAMCTRL_API int __stdcall MV_CC_TriggerSoftwareExecute(IN void* handle);


// Gamma ����
MV_CAMCTRL_API int __stdcall MV_CC_GetGammaSelector(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetGammaSelector(IN void* handle, IN const unsigned int nValue);

// Gammaֵ
MV_CAMCTRL_API int __stdcall MV_CC_GetGamma(IN void* handle, IN OUT MVCC_FLOATVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetGamma(IN void* handle, IN const float fValue);

// ���
MV_CAMCTRL_API int __stdcall MV_CC_GetSharpness(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetSharpness(IN void* handle, IN const unsigned int nValue);

// �Ҷ�
MV_CAMCTRL_API int __stdcall MV_CC_GetHue(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetHue(IN void* handle, IN const unsigned int nValue);

// ���Ͷ�
MV_CAMCTRL_API int __stdcall MV_CC_GetSaturation(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetSaturation(IN void* handle, IN const unsigned int nValue);

// �Զ���ƽ��
MV_CAMCTRL_API int __stdcall MV_CC_GetBalanceWhiteAuto(IN void* handle, IN OUT MVCC_ENUMVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetBalanceWhiteAuto(IN void* handle, IN const unsigned int nValue);

// ��ƽ�� ��
MV_CAMCTRL_API int __stdcall MV_CC_GetBalanceRatioRed(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetBalanceRatioRed(IN void* handle, IN const unsigned int nValue);

// ��ƽ�� ��
MV_CAMCTRL_API int __stdcall MV_CC_GetBalanceRatioGreen(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetBalanceRatioGreen(IN void* handle, IN const unsigned int nValue);

// ��ƽ�� ��
MV_CAMCTRL_API int __stdcall MV_CC_GetBalanceRatioBlue(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetBalanceRatioBlue(IN void* handle, IN const unsigned int nValue);


// ��ȡˮӡ��Ϣ�ڰ�������Ϣ����
MV_CAMCTRL_API int __stdcall MV_CC_GetFrameSpecInfoAbility(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetFrameSpecInfoAbility(IN void* handle, IN const unsigned int nValue);


MV_CAMCTRL_API int __stdcall MV_CC_GetDeviceUserID(IN void* handle, IN OUT MVCC_STRINGVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_CC_SetDeviceUserID(IN void* handle, IN const char* chValue);


// ��ȡͼ�������Ϣ
MV_CAMCTRL_API int __stdcall MV_CC_GetImageInfo(IN void* handle, IN OUT MV_IMAGE_BASIC_INFO* pstInfo);
MV_CAMCTRL_API int __stdcall MV_CC_GetDeviceInfo(IN void * handle, IN OUT MV_CC_DEVICE_INFO* pstDevInfo);
// ��ȡ�������͵���Ϣ
MV_CAMCTRL_API int __stdcall MV_CC_GetAllMatchInfo(IN void* handle, IN OUT MV_ALL_MATCH_INFO* pstInfo);



/************************************************************************/
/* �豸���� �� �Ĵ�����д ���쳣�ص�                                        */
/************************************************************************/
// �豸��������
MV_CAMCTRL_API int __stdcall MV_CC_LocalUpgrade(IN void* handle, const void *pFilePathName);
// ��ȡ��ǰ��������
MV_CAMCTRL_API int __stdcall MV_CC_GetUpgradeProcess(IN void* handle, unsigned int* pnProcess);
// ��ȡ��ѵ�packet size����ӦGigEVision�豸�� SCPS����ӦU3V�豸��ÿ�δ�������ȡ�İ���С
MV_CAMCTRL_API int __stdcall MV_CC_GetOptimalPacketSize(IN void* handle);
MV_CAMCTRL_API int __stdcall MV_CC_ReadMemory(IN void* handle , void *pBuffer, __int64 nAddress, __int64 nLength);
MV_CAMCTRL_API int __stdcall MV_CC_WriteMemory(IN void* handle , const void *pBuffer, __int64 nAddress, __int64 nLength);
// ע���쳣��Ϣ�ص�
MV_CAMCTRL_API int __stdcall MV_CC_RegisterExceptionCallBack(IN void* handle, 
                                                             void(__stdcall* cbException)(unsigned int nMsgType, void* pUser),
                                                             void* pUser);

/************************************************************************/
/* GigEVision �豸���еĽӿ�                                            */
/************************************************************************/
// ǿ��IP
MV_CAMCTRL_API int __stdcall MV_GIGE_ForceIp(IN void* handle, unsigned int nIP);

// ����IP��ʽ��type��MV_IP_CFG_x
MV_CAMCTRL_API int __stdcall MV_GIGE_SetIpConfig(IN void* handle, unsigned int nType);

// ���ý�ʹ��ĳ��ģʽ,type: MV_NET_TRANS_x��������ʱ��Ĭ������ʹ��driver
MV_CAMCTRL_API int __stdcall MV_GIGE_SetNetTransMode(IN void* handle, unsigned int nType);

MV_CAMCTRL_API int __stdcall MV_GIGE_GetNetTransInfo(IN void* handle, MV_NETTRANS_INFO* pstInfo);

// �����������С
MV_CAMCTRL_API int __stdcall MV_GIGE_GetGevSCPSPacketSize(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_GIGE_SetGevSCPSPacketSize(IN void* handle, IN const unsigned int nValue);

// ������������ͼ��
MV_CAMCTRL_API int __stdcall MV_GIGE_GetGevSCPD(IN void* handle, IN OUT MVCC_INTVALUE* pstValue);
MV_CAMCTRL_API int __stdcall MV_GIGE_SetGevSCPD(IN void* handle, IN const unsigned int nValue);

// ���ý��ն�IP��ַ��0xa9fe0102 ��ʾ 169.254.1.2
MV_CAMCTRL_API int __stdcall MV_GIGE_GetGevSCDA(IN void* handle, unsigned int* pnIP);
MV_CAMCTRL_API int __stdcall MV_GIGE_SetGevSCDA(IN void* handle, unsigned int nIP);

// ���÷��Ͷ˵Ķ˿ں�
MV_CAMCTRL_API int __stdcall MV_GIGE_GetGevSCSP(IN void* handle, unsigned int* pnPort);
MV_CAMCTRL_API int __stdcall MV_GIGE_SetGevSCSP(IN void* handle, unsigned int nPort);




// ��������


#ifdef __cplusplus
}
#endif 

#endif //_MV_CAMERA_CTRL_H_
