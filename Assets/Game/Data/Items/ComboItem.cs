using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Item", menuName = "MyGame/Data/ComboItem")]
    public class ComboItem : ScriptableObject
    {
        public string itemName;
        public Sprite icon;
        public string description;
        public List<Item> comboOfItems;
        public List<StatAffected> statAffected;
        public List<ComboStatAffected> comboStatAffected;
    }

    [System.Serializable]
    public class ComboStatAffected
    {
        public bool isUniqueOnePerChampion;
        public AffectType affectType;
        public List<Status> statuses;
        public Stat stat;
        public float amount;
        public bool isAmountInPercent;
        public float durationInSec;
        public List<Condition> conditions;
    }

    [System.Serializable]
    public class Condition
    {
        public List<Character> charactersToAffect;
        public List<HexGrid> hexGridCondition;
        public Stat statToCheck;
        public float amount;
        public bool isAmountInPercent;
        public ValueOperator valueOperator;
    }

    [System.Serializable]
    public enum ValueOperator
    {
        none,
        less,
        equal,
        greater,
    }

    [System.Serializable]
    public enum Character
    {
        player,
        ally,
        enemy,
    }

    [System.Serializable]
    public enum HexGrid
    {
        all,
        holder,
        sameRow,
        sameColumn,
        sameRow1Hex,
        sameColumn1Hex,
        topRow,
        bottomRow,
        left,
        right
    }

    [System.Serializable]
    public enum AffectType
    {
        none,
        oncePerCombat,
        omnivamp,
        everyThirdAttack,
        combatStart
    }

    [System.Serializable]
    public enum Status
    {
        none,
        stealthed,
        untargettable,
        sheedingNegativeEffects
    }
}