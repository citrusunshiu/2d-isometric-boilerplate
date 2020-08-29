using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Models;

public class SkillHub : Skill
{
    public SkillHub(string skillJSONFileName, int levelObtained, int progressionPointObtained) : base(skillJSONFileName, levelObtained, progressionPointObtained)
    {

    }

    #region Functions
    #region Test Skill
    private void TestSkill()
    {
        Debug.Log("Skill:TestSkill running");
    }

    private void TestSkillLogic()
    {
        Debug.Log("Skill:TestSkillLogic running");
    }
    #endregion



    #endregion
}
