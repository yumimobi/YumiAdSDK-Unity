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

            client = YumiAdsClientFactory.BuildDebugCenterClient();
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
