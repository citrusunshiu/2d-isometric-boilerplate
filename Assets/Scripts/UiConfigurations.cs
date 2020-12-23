using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YuguLibrary.Enumerations;
using YuguLibrary.Utilities;

namespace UIConfirgurations
{
    public class UICLanding : UIConfiguration
    {
        public UICLanding()
        {
            screen = UIScreens.Landing;
            uiFileName = "File Select";
        }

        public override void LoadUI(GameObject uiContainer)
        {

        }
    }

    public class UICLandingFileSelect : UIConfiguration
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
        PlayerFile encounterTestFile;
        PlayerFile actionTestFile;
        PlayerFile overworldStrollFile;

        public UICLandingFileSelect()
        {
            screen = UIScreens.Landing_FileSelect;
            uiFileName = "File Select";
            files = new List<PlayerFile>();
            LoadPlayerFiles();
        }

        public override void LoadUI(GameObject uiContainer)
        {
            LoadUIScreenFromPrefab(uiContainer);
            Button[] buttons = uiContainer.GetComponentsInChildren<Button>();
            foreach(Button b in buttons)
            {
                switch (b.name)
                {
                    case "Button (Select File 1)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.File1);
                        });
                        break;
                    case "Button (Select File 2)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.File2);
                        });
                        break;
                    case "Button (Select File 3)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.File3);
                        });
                        break;
                    case "Button (Select Encounter Test)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.File1);
                        });
                        break;
                    case "Button (Select Action Test)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.ActionTest);
                        });
                        break;
                    case "Button (Select Overworld Stroll)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.OverworldStroll);
                        });
                        break;
                    case "Button (Select Options)":
                        b.onClick.AddListener(delegate {
                            SelectOption(PlayerOptions.Options);
                        });
                        break;
                    default:
                        break;
                }
            }
            SelectButton(uiContainer);

            SelectOption(PlayerOptions.EncounterTest);
        }

        private void LoadPlayerFiles()
        {
            files.Add(PlayerFile.CreateNewFile());
            files.Add(PlayerFile.CreateNewFile());
            files.Add(PlayerFile.CreateNewFile());

            encounterTestFile = PlayerFile.CreateTestFile();
            actionTestFile = new PlayerFile();
            overworldStrollFile = new PlayerFile();
        }

        private void SelectOption(PlayerOptions option)
        {
            switch (option)
            {
                case PlayerOptions.File1:
                    LoadInstanceFromPlayerFile(files[0]);
                    break;
                case PlayerOptions.File2:
                    LoadInstanceFromPlayerFile(files[1]);
                    break;
                case PlayerOptions.File3:
                    LoadInstanceFromPlayerFile(files[2]);
                    break;
                case PlayerOptions.EncounterTest:
                    LoadInstanceFromPlayerFile(encounterTestFile);
                    break;
                case PlayerOptions.ActionTest:
                    LoadInstanceFromPlayerFile(actionTestFile);
                    break;
                case PlayerOptions.OverworldStroll:
                    LoadInstanceFromPlayerFile(overworldStrollFile);
                    break;
                case PlayerOptions.Options:
                    break;
            }
        }

        private void LoadInstanceFromPlayerFile(PlayerFile playerFile)
        {
            UtilityFunctions.SetCurrentFile(playerFile);
            UtilityFunctions.LoadCurrentPlayerFile();
        }

    }

    public class UICOverworld : UIConfiguration
    {
        public UICOverworld()
        {
            screen = UIScreens.Overworld;
            uiFileName = "Overworld";
        }

        public override void LoadUI(GameObject uiContainer)
        {
            LoadUIScreenFromPrefab(uiContainer);
        }
    }

    public class UICMenu : UIConfiguration
    {
        public UICMenu()
        {
            screen = UIScreens.Menu;
            uiFileName = "Menu";
        }

        public override void LoadUI(GameObject uiContainer)
        {
            LoadUIScreenFromPrefab(uiContainer);
        }
    }

    public class UICEncounter : UIConfiguration
    {
        public UICEncounter()
        {
            screen = UIScreens.Encounter;
            uiFileName = "Encounter";
        }

        public override void LoadUI(GameObject uiContainer)
        {
            LoadUIScreenFromPrefab(uiContainer);
        }
    }

    public class UICCutscene : UIConfiguration
    {
        public UICCutscene()
        {
            screen = UIScreens.Cutscene;
            uiFileName = "Cutscene";
        }

        public override void LoadUI(GameObject uiContainer)
        {
            LoadUIScreenFromPrefab(uiContainer);
        }
    }

}
