using UIConfirgurations;
using UnityEngine;
using UnityEngine.Tilemaps;
using YuguLibrary.Controllers;
using YuguLibrary.Enumerations;
using YuguLibrary.Models;
using YuguLibrary.OverworldObjectActions;
using YuguLibrary.Utilities;

public class UnitDetectorController : MonoBehaviour
{
    public UnitDetector unitDetector;

    public Tilemap indicators;
    public Tilemap geography;

    void Awake()
    {
        SetActiveUnitDetector(new UnitDetector(geography, indicators, this));
    }

    // Start is called before the first frame update
    void Start()
    {

        UtilityFunctions.GetActiveUIManager().PushUI(new UICOverworld(), true);
    }

    // Update is called once per frame
    void Update()
    {
        if(unitDetector != null)
        {
            unitDetector.AssignAndExecuteUnitAIs();
        }
    }

    void SetActiveUnitDetector(UnitDetector unitDetector)
    {
        this.unitDetector = unitDetector;
    }
}
