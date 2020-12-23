using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Controllers;

public class EncounterController : MonoBehaviour
{
    public Encounter encounter;

    void Awake()
    {
        SetActiveEncounter(new Encounter(this));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetActiveEncounter(Encounter encounter)
    {
        this.encounter = encounter;
    }
}
