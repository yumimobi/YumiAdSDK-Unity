#if UNITY_ANDROID
using System;
using YumiMediationSDK.Common;
using UnityEngine;

namespace YumiMediationSDK.Android
{
    public class YumiDebugCenterClient : IYumiDebugCenterClient
    {
        private AndroidJavaObject debugcenter;
        public YumiDebugCenterClient()
        {
            AndroidJavaClass playerClass = new AndroidJavaClass(YumiUtils.UnityActivityClassName);
            AndroidJavaObject activity =
                    playerClass.GetStatic<AndroidJavaObject>("currentActivity");
            debugcenter = new AndroidJavaObject(
                YumiUtils.DebugCenterClassName, activity);
        }

        public void ChangeToTestServer()
        {
            debugcenter.Call("changeToTestServer");
        }
    }
}
#endif