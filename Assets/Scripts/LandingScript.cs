using System.Collections;
using System.Collections.Generic;
using UIConfirgurations;
using UnityEngine;
using UnityEngine.SceneManagement;
using YuguLibrary.Controllers;
using YuguLibrary.Enumerations;
using YuguLibrary.Utilities;

public class LandingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UtilityFunctions.GetActiveUIManager().PushUI(new UICLandingFileSelect(), false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
