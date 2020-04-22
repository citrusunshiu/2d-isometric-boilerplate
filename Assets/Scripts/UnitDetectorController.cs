﻿using Instances;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        Unit unit = new Unit("unit.json", 1, TargetTypes.Ally);
        Instance instance = new Instance("dummy-room.json");
        Skill skill = new Skill("", 0, 0);

        Debug.Log(UtilityFunctions.GetStringFromSQL("selection_yes"));
        
        unitDetector.LoadNewInstance(instance, new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActiveUnitDetector().SpawnOverworldObject(unit, new Vector3Int(11, 0, 1));
        UtilityFunctions.GetActivePlayer().SetCurrentOverworldObject(unit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
