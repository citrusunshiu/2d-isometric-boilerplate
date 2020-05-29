using UnityEngine;
using UnityEngine.Tilemaps;
using YuguLibrary.Controllers;
using YuguLibrary.Enumerations;
using YuguLibrary.Models;
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
        Debug.Log("udc started");
        Unit unit = new Unit("Sample/Sample Unit/unit.json", 1, TargetTypes.Ally);
        Unit enemyUnit = new Unit("Sample/Sample Unit/unit.json", 1, TargetTypes.Enemy);
        Instance instance = new Instance("dummy-room.json");
        Skill skill = new SkillHub("Sample/Sample Unit/Skills/skill.json", 0, 0);
        skill.ExecuteSkill();
        AnimationScript animationScript = new AnimationScript("Sample/Sample Unit/unit-animation.json");

        Debug.Log(UtilityFunctions.GetStringFromSQL("selection_yes"));
        
        unitDetector.LoadNewInstance(instance, new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActiveUnitDetector().SpawnOverworldObject(unit, new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActiveUnitDetector().SpawnOverworldObject(enemyUnit, new Vector3Int(15, 0, 1));
        UtilityFunctions.GetActivePlayer().SetCurrentOverworldObject(unit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetActiveUnitDetector(UnitDetector unitDetector)
    {
        this.unitDetector = unitDetector;
    }
}
