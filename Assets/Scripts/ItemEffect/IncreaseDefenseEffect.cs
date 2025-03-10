using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class UsableItemEffect : UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int DefenseBoost;
    public Sprite EffectSprite;

    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.defense = DefenseBoost;

        VFXManager.PlayVFX(VFXType.Stronger , user.transform.position);

        user.Stats.AddTimedModifier(modifier, Duration, "AgilityAdd", EffectSprite);
        
        return true;
    }
}
