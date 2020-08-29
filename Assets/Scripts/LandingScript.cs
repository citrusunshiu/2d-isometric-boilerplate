using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        LoadPlayerFiles();
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
                break;
            case PlayerOptions.File2:
                break;
            case PlayerOptions.File3:
                break;
            case PlayerOptions.EncounterTest:
                break;
            case PlayerOptions.ActionTest:
                break;
            case PlayerOptions.OverworldStroll:
                break;
            case PlayerOptions.Options:
                break;
        }
    }

    private void LoadInstanceFromPlayerFile(PlayerFile playerFile)
    {

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
