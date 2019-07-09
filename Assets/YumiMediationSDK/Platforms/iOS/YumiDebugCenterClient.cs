#if UNITY_IOS
using System;
using YumiMediationSDK.Common;

namespace YumiMediationSDK.iOS
{
    public class YumiDebugCenterClient  : IYumiDebugCenterClient
    {
        public void ChangeToTestServer(){
            YumiExterns.EnableTestMode();
        }
    }
}
#endif