using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;
using Firebase.Analytics;

public class MyEventSystem : MonoBehaviour
{
    public static MyEventSystem I;

    private void Awake()
    {
        I = this;
        GameAnalytics.Initialize();
        DontDestroyOnLoad(gameObject);
    }

    public void StartLevel(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, level.ToString());
        FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventLevelStart, level.ToString(), level);

    }

    public void FailLevel(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, level.ToString());
        FirebaseAnalytics.LogEvent("Fail", level.ToString(), level);
    }
    
    public void CompleteLevel(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, level.ToString());
        FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventLevelEnd, level.ToString(), level);
        Debug.Log(FirebaseAnalytics.EventLevelEnd);
    }
}
