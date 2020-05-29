using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary;

public class StatusHub : Status
{
    public StatusHub(string statusJSONFileName, int duration) : base(statusJSONFileName, duration)
    {
    }

    private void TestStatus()
    {
        Debug.Log("Status:TestStatus running");
    }
}
