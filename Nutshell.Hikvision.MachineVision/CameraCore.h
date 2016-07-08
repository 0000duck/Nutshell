// Nutshell.Hikvision.Mvision.h

#pragma once

#include "Stdafx.h"
#include"MvCameraControl.h"
#include"RuntimeCore.h"

namespace Nutshell
{
	namespace Hikvision
	{
		namespace Mvision
		{
			public ref class CameraCore
			{
			private:
				void** handle;
				MV_CC_DEVICE_INFO* deviceInfo;

			public:
				 int  OpenDevice(IPAddress^ ipAddress);
				 int  CloseDevice();

				 /************************************************************************/
				 /* ����ɼ�                                                 */
				 /************************************************************************/

				 int  StartGrabbing();
				 int  StopGrabbing();
				 int  GetOneFrame(Bitmap^ bitmap);

				/************************************************************************/
				/* ���������ȡ������                                                   */
				/************************************************************************/

				// ��ȡ������ͼ����
				// int  GetWidth(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetWidth(IN const unsigned int nValue);

				//// ��ȡ������ͼ��߶�
				// int  GetHeight(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetHeight(IN const unsigned int nValue);

				//// ��ȡ������AOI��ƫ��
				// int  GetAOIoffsetX(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetAOIoffsetX(IN const unsigned int nValue);

				//// ��ȡ������AOI��ƫ��
				// int  GetAOIoffsetY(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetAOIoffsetY(IN const unsigned int nValue);

				//// �����Զ��ع�ֵ����
				// int  GetAutoExposureTimeLower(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetAutoExposureTimeLower(IN const unsigned int nValue);

				////�����Զ��ع�ֵ����
				// int  GetAutoExposureTimeUpper(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetAutoExposureTimeUpper(IN const unsigned int nValue);

				//// �����ȵ���
				// int  GetBrightness(IN OUT MVCC_INTVALUE* pstValue);
				// int  SetBrightness(IN const unsigned int nValue);

				//// ��ȡ������֡��
				// int  GetFrameRate(IN OUT MVCC_FLOATVALUE* pstValue);
				// int  SetFrameRate(IN const float fValue);

				//
				//// ������ǰ�ع�ֵ
				// int  GetExposureTime(IN OUT MVCC_FLOATVALUE* pstValue);
				// int  SetExposureTime(IN const float fValue);

				//// ��ȡ���������ظ�ʽ
				// int  GetPixelFormat(IN OUT MVCC_ENUMVALUE* pstValue);
				// int  SetPixelFormat(IN const unsigned int nValue);

				//// �ɼ�ģʽ
				// int  GetAcquisitionMode(IN OUT MVCC_ENUMVALUE* pstValue);
				// int  SetAcquisitionMode(IN const unsigned int nValue);
				//
				//// ��ȡͼ�������Ϣ
				// int  GetImageInfo(IN OUT MV_IMAGE_BASIC_INFO* pstInfo);
				// int  GetDeviceInfo(IN void * handle, IN OUT MV_CC_DEVICE_INFO* pstDevInfo);
			};
		}
	}
}
