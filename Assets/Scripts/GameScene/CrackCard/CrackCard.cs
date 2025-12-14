using UnityEngine;

[CreateAssetMenu(fileName = "CrackCard", menuName = "ScriptableObjects/CrackCard")]
public class CrackCard : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite icon;
    public CrackCardType cardType;

    public SpellEffectType spellEffect; 
    public TrapEffectType trapEffect;   
}

public enum CrackCardType
{
    Spell, // 마법카드
    Trap   // 함정카드
}

public enum SpellEffectType
{
    None,           
    DoubleScore,
    HeartOfTheBeast,
    Gamble
}

public enum TrapEffectType
{
    None,           
    SwapScoresIfLosing,
    BlockOpponentScore
}
