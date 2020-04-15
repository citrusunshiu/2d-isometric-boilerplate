using Instances;
using System.Collections;
using System.Collections.Generic;
using Units;
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
        unitDetector = new UnitDetector(geography, indicators, this);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("udc started");
        TestUnit unit = new TestUnit(1, TargetTypes.Ally);
        unitDetector.LoadNewInstance(new DummyRoom(), new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActiveUnitDetector().SpawnOverworldObject(unit, new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActivePlayer().SetPlayerUnit(unit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
