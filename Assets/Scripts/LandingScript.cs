using System.Collections;
using System.Collections.Generic;
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

    PlayerFile file1;
    PlayerFile file2;
    PlayerFile file3;

    PlayerFile encounterTest;
    PlayerFile actionTest;
    PlayerFile overworldStroll;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("in landing");
        LoadPlayerFiles();
        UtilityFunctions.GetActiveUIManager().PushUI(YuguUIScreens.Landing, true);
        UtilityFunctions.GetActiveUIManager().PushUI(YuguUIScreens.Landing_FileSelect, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SelectOption(PlayerOptions option)
    {
        switch (option)
        {
            case PlayerOptions.File1:
                LoadInstanceFromPlayerFile(file1);
                break;
            case PlayerOptions.File2:
                LoadInstanceFromPlayerFile(file2);
                break;
            case PlayerOptions.File3:
                LoadInstanceFromPlayerFile(file3);
                break;
            case PlayerOptions.EncounterTest:
                LoadInstanceFromPlayerFile(encounterTest);
                break;
            case PlayerOptions.ActionTest:
                LoadInstanceFromPlayerFile(actionTest);
                break;
            case PlayerOptions.OverworldStroll:
                LoadInstanceFromPlayerFile(overworldStroll);
                break;
            case PlayerOptions.Options:
                break;
        }
    }

    private void LoadInstanceFromPlayerFile(PlayerFile playerFile)
    {
        UtilityFunctions.SetCurrentFile(playerFile);
        SceneManager.LoadScene("Instance");
    }

    private void LoadPlayerFiles()
    {
        file1 = new PlayerFile();
        file2 = new PlayerFile();
        file3 = new PlayerFile();

        encounterTest = new PlayerFile();
        actionTest = new PlayerFile();
        overworldStroll = new PlayerFile();
    }
}
