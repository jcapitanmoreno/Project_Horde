using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
   public string Name;
   public int armor;


   public void Equip(Character character)
   {
    character.armor += armor;
   }

   public void UnEquipt(Character character)
   {
    character.armor -= armor;
   }
}
