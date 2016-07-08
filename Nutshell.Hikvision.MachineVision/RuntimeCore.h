#pragma once

#include"Stdafx.h"
#include"MvCameraControl.h"

namespace Nutshell
{
	namespace Hikvision
	{
		namespace Mvision
		{
			public ref class RuntimeCore
			{
			private:
				static RuntimeCore^ _instance;
				MV_CC_DEVICE_INFO_LIST* DeviceInfoList;

			public:
				static property RuntimeCore^ Instance
				{
					RuntimeCore^ get()
					{
						if (_instance == nullptr)
						{
							//TODO: ��Ҫ���Ӷ��̻߳������Ʊ�֤�����ظ���ʼ��
							_instance = gcnew RuntimeCore();
						}
						return _instance;
					}
				}

			public:
				unsigned int GetSDKVersion();
				bool IsEnableGigeDevices();
				int EnumDevices();
				bool FindDevice(IPAddress^ ipAddress, MV_CC_DEVICE_INFO* deviceInfo);
			};
		}
	}
}
