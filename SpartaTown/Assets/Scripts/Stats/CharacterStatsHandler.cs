using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;

    public CharacterStat CurrentStat { get; private set; }

    public List<CharacterStat> statModifiers = new List<CharacterStat>();

    private void Awake()
    {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        CurrentStat.statsChangeType = baseStat.statsChangeType;;
        CurrentStat.speed = baseStat.speed;
    }
}