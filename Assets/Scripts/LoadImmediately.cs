using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;


public class LoadImmediately : MonoBehaviour
{
    public GameObject levelManager;
    private void Awake()
    {
        levelManager.GetComponent<LevelManager>().LoadLevel("Level1");
    }
}
