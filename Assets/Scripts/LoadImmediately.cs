using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;

public class LoadImmediately : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("Level1");
    }
}
