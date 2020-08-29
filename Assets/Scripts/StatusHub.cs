using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary;

public class StatusHub : Status
{
    public StatusHub(string statusJSONFileName, int duration) : base(statusJSONFileName, duration)
    {
    }

    #region Functions
    #region Test Status
    private void TestStatus()
    {
        Debug.Log("Status:TestStatus running");
    }
    #endregion


    #endregion
}
