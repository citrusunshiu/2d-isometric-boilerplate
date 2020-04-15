using AnimationScripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Enumerations;
using YuguLibrary.Models;

namespace Units
{
    public class TestUnit : Unit
    {
        public override string Name => "Test Unit";

        public override UnitRoles Role => UnitRoles.Melee;

        public override UnitClassifications Classification => UnitClassifications.Regular;

        public override int BaseMovementRadius => 5;

        public override SpeedTiers SpeedTier => SpeedTiers.VeryFast;

        public override AnimationScript AnimationScript => new TestUnitAnimationScript();

        protected override float HPScaling => HP_SCALING_AVERAGE;

        protected override float MPScaling => MPREGEN_SCALING_AVERAGE;

        protected override float MPRegenScaling => MPREGEN_SCALING_AVERAGE;

        protected override float PhysicalAttackScaling => PHYSICALATTACK_SCALING_AVERAGE;

        protected override float MagicalAttackScaling => MAGICALATTACK_SCALING_AVERAGE;

        protected override float PhysicalDefenseScaling => PHYSICALDEFENSE_SCALING_AVERAGE;

        protected override float MagicalDefenseScaling => MAGICALDEFENSE_SCALING_AVERAGE;

        protected override float SpeedScaling => SPEED_SCALING_AVERAGE;

        protected override float StaggerThresholdScaling => STAGGERTHRESHOLD_SCALING_AVERAGE;

        public TestUnit(int level, TargetTypes targetType) : base(level, targetType)
        {

        }

        protected override void InitializeEncounterAIs()
        {

        }

        protected override void InitializeOverworldAIs()
        {

        }

        protected override void InitializeOverworldSkills()
        {

        }

        protected override void InitializeSkills()
        {

        }
    }
}