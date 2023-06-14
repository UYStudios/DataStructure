using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Item", menuName = "MyGame/Data/Item")]
    public class Item : ScriptableObject
    {
        public string itemName;
        public Sprite icon;
        public string description;
        public List<StatAffected> statAffected;
    }

    [System.Serializable]
    public class StatAffected
    {
        public Stat stat;
        public float amount;
        public bool isAmountInPercent;
    }

    public enum Stat
    {
        attackDamage,
        attackSpeed,
        armor,
        magicResist,
        abilityPower,
        mana,
        health,
        criticalStrikeChance,
        healthShield,
        omnivamp
    }
}