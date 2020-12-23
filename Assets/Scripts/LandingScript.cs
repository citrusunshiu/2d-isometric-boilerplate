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
    enum PlayerOptions
    {
        File1,
        File2,
        File3,
        EncounterTest,
        ActionTest,
        OverworldStroll,
        Options
    };

    List<PlayerFile> files;

    PlayerFile encounterTest;
    PlayerFile actionTest;
    PlayerFile overworldStroll;


    // Start is called before the first frame update
    void Start()
    {
        files = new List<PlayerFile>();
        UtilityFunctions.GetActiveUIManager().PushUI(new UICLandingFileSelect(), false);
        //LoadInstanceFromPlayerFile(files[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
