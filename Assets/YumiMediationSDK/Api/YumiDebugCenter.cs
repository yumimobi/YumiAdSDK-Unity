using System;
using YumiMediationSDK.Common;
using System.Reflection;

namespace YumiMediationSDK.Api
{
    public class YumiDebugCenter
    {
        private IYumiDebugCenterClient client;
        /// <summary>
        /// Initializes a new instance
        /// </summary>
        public YumiDebugCenter()
        {
            Type yumiAdsClientFactory = Type.GetType(
                  "YumiMediationSDK.YumiAdsClientFactory,Assembly-CSharp");
            MethodInfo method = yumiAdsClientFactory.GetMethod(
                "BuildDebugCenterClient",
                BindingFlags.Static | BindingFlags.Public);
            this.client = (IYumiDebugCenterClient)method.Invoke(null, null);
        }
        
        /// <summary>
        /// Changes to test server.
        /// </summary>
        public void ChangeToTestServer()
        {
            client.ChangeToTestServer();
        }
    }
}
