﻿using System;
using YumiMediationSDK.Api;
using UnityEngine;
using System.Collections.Generic;

namespace YumiMediationSDK.Common
{
    public class YumiDummyClient : IYumiBannerClient,IYumiInterstitialClient,IYumiRewardVideoClient,IYumiDebugCenterClient, IYumiNativeClient, IYumiSplashClient, IYumiGDPRManagerClient
    {
        public YumiDummyClient()
        {
            Logger.LogError("dummy client");
        }
        // Disable warnings for unused dummy ad events.
#pragma warning disable 67
        // Ad event fired when ad has been load.
        public event EventHandler<EventArgs> OnAdLoaded;
        // Ad event fired when ad has failed to load.
        public event EventHandler<YumiAdFailedToLoadEventArgs> OnAdFailedToLoad;
        // Ad event fired when ad has failed to show.
        public event EventHandler<YumiAdFailedToShowEventArgs> OnAdFailedToShow;
        // Ad event fired when ad is opened.
        public event EventHandler<EventArgs> OnAdOpening;
        // Ad event fired when ad has started playing.
        public event EventHandler<EventArgs> OnAdStartPlaying;
        // Ad event fired when video ad is closed.
        public event EventHandler<YumiAdCloseEventArgs> OnRewardVideoAdClosed;
         // Ad event fired when the interstitial ad is closed.
        public event EventHandler<EventArgs> OnAdClosed;
        // Ad event fired when ad is clicked.
        public event EventHandler<EventArgs> OnAdClicked;

        // Ad event fired when the banner ad is click.
        public event EventHandler<EventArgs> OnAdClick;
        // Ad event fired when the reward based video ad has rewarded the user.
        public event EventHandler<EventArgs> OnAdRewarded;
        //native ad load 
        public event EventHandler<YumiNativeToLoadEventArgs> OnNativeAdLoaded;

        // splash
        // Ad event fired when the splash ad success to show 
        public event EventHandler<EventArgs> OnAdSuccessToShow;

        // native express ad
        
        /// Ad event fired when the native  express ad has been successed
        public event EventHandler<YumiNativeDataEventArgs> OnExpressAdRenderSuccess;
        /// Ad event fired when the native  express ad has been failed.
        public event EventHandler<YumiAdFailedToRenderEventArgs> OnExpressAdRenderFail;
        // Ad event fired when the native  express ad has been click close button.
        public event EventHandler<YumiNativeDataEventArgs> OnExpressAdClickCloseButton;

#pragma warning restore 67
        // banner method
        // Creates a banner view and adds it to the view hierarchy.
        public void CreateBannerView(string placementId, string channelId, string versionId, YumiBannerViewOptions bannerOptions)
        {
            Logger.LogError("Dummy : create banner");
        }

        // Requests a new ad for the banner view.
        public void LoadAd(bool isSmart){
            Logger.LogError("Dummy :load ad");
        }

        // Shows the banner view on the screen.
        public void ShowBannerView(){
            Logger.LogError("Dummy: ShowBannerView");
        }

        // Hides the banner view from the screen.
        public void HideBannerView(){
            Logger.LogError("Dummy: HideBannerView");
        }

        // Destroys a banner view.
        public void DestroyBannerView(){
            Logger.LogError("Dummy: DestroyBannerView");
        }

        // Creates an InterstitialAd.
        public void CreateInterstitialAd(string placementId, string channelId, string versionId){
            Logger.LogError("Dummy: CreateInterstitialAd");
        }

        // Determines whether the interstitial has loaded.
        public bool IsInterstitialReady(){
            Logger.LogError("Dummy: IsInterstitialReady");
            return false;
        }

        // Shows the InterstitialAd.
        public void ShowInterstitial(){
            Logger.LogError("Dummy: ShowInterstitial");
        }

        // Destroys an InterstitialAd.
        public void DestroyInterstitial(){
            Logger.LogError("Dummy: DestroyInterstitial");
        }

        //vdieo 
        // Creates an RewardVideo.
        public void CreateRewardVideoAd(){
            Logger.LogError("Dummy: CreateRewardVideoAd");
        }
        // load RewardVideo
        public void LoadRewardVideoAd(string placementId, string channelId, string versionId){
            Logger.LogError("Dummy: LoadRewardVideoAd");
        }

        // Determines whether the interstitial has loaded.
        public  bool IsRewardVideoReady(){
            Logger.LogError("Dummy: IsRewardVideoReady");
            return false;
        }

        // Shows the RewardVideo.
        public  void PlayRewardVideo(){
            Logger.LogError("Dummy: PlayRewardVideo");
        }

        // Destroys an RewardVideo.
        public void DestroyRewardVideo(){
            Logger.LogError("Dummy: DestroyRewardVideo");
        }
        public void CallYumiMediationDebugCenter(string bannerPlacementID, string interstitialPlacementID, string videoPlacementID, string nativePlamentID, string splashPlacementID, string channelID, string versionID)
        {
            Logger.LogError("Dummy: CallYumiMediationDebugCenter");
        }

        public void ChangeToTestServer()
        {
            Logger.LogError("Dummy: ChangeYumiMode ");
        }

        // native ad
        // Creates a native ad

        public void CreateNativeAd(string placementId, string channelId, string versionId, GameObject gameObject, YumiNativeAdOptions options)
        {
            Logger.LogError("Dummy: call CreateNativeAd");
        }

        public void LoadAd(int adCount)
        {
            Logger.LogError("Dummy: call LoadAd");
        }

        public void ReportImpression(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call ReportImpression");
        }

        public void ReportClick(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call ReportClick");
        }

        public void DestroyNativeAd()
        {
            Logger.LogError("Dummy: call DestroyNativeAd");
        }

        public void RegisterNativeDataForInteraction(YumiNativeData yumiNaitveData, Dictionary<NativeElemetType, Transform> elements)
        {
            Logger.LogError("Dummy: call RegisterGameObjectsForInteraction");
        }

        public bool IsAdInvalidated(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call IsAdInvalidated");
            return false;
        }

        public void ShowView(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call ShowView");
        }

        public void HideView(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call HideView");
        }

        public void UnregisterView(YumiNativeData nativeData)
        {
            Logger.LogError("Dummy: call UnregisterView");
        }

        // splash
        // Creates an Splash.
        public void CreateSplashAd(string placementId, string channelId, string versionId, YumiSplashOptions splashOptions)
        {
            Logger.LogError("Dummy: CreateSplashAd");
        }
        //load and show full screen splash
        public void LoadAdAndShow()
        {
            Logger.LogError("Dummy: LoadAdAndShow");
        }
        public void DestroySplashAd()
        {
            Logger.LogError("Dummy: DestroySplashAd");
        }
        // gdpr
        public void CreateGDPRManager()
        {
            Logger.LogError("Dummy: CreateGDPRManager");
        }
       
        public void UpdateNetworksConsentStatus(YumiConsentStatus consentStatus)
        {
            Logger.LogError("Dummy: UpdateNetworksConsentStatus");
        }
    }
}
