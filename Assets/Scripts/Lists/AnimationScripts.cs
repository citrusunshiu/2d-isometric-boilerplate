using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Models;

namespace AnimationScripts
{
    public class TestUnitAnimationScript : AnimationScript
    {
        public TestUnitAnimationScript()
        {
            spritesheet = Resources.LoadAll("Sprites/Units/testanimsheet");
        }
    }
}