using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EquippedItemEffect : EquipmentItem.EquippedEffect
{
     public int StrengthChange = 3;
     
     public override void Equipped(CharacterData user)
     {
          StatSystem.StatModifier modifier = new StatSystem.StatModifier();
          modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
          modifier.Stats.strength = StrengthChange;
          
          VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);
          
          user.Stats.AddModifier(modifier);
     }
     public override void Removed(CharacterData user)
     {
          StatSystem.StatModifier modifier = new StatSystem.StatModifier();
          modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
          modifier.Stats.strength = StrengthChange;
          
          VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);
          
          user.Stats.RemoveModifier(modifier);
     }
}
