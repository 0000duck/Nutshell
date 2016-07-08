/***************************************************************************************************
* 
* ��Ȩ��Ϣ����Ȩ���� (c) 2015, ���ݺ����������ּ����ɷ����޹�˾, ��������Ȩ��
* 
* �ļ����ƣ�MvInclude.h
* ժ    Ҫ��ͷ�ļ����������Ͷ����
*
* ��ǰ�汾��1.0.0.0
* ��    �ߣ�������
* ��    �ڣ�2015-02-03
* ��    ע���½�
***************************************************************************************************/
#ifndef _MV_INCLUDE_H_
#define _MV_INCLUDE_H_

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


namespace MvCamCtrl
{

    typedef  void       ITransportLayer;
    typedef  void*      TlProxy;
    class               MvCamera;
    class               CTlRefs;
    class               CDevRefs;


}

#endif /* _MV_INCLUDE_H_ */
