using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Models;

public static class UnitAIHub
{
    public static UnitAIAction TestUnitAIHub(Unit unit)
    {
        UnitAIAction unitAIAction;
        unitAIAction = UnitAILogic.RandomMove(unit);
        return null;
    }
}
