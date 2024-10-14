using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[System.Serializable]

public class CharacterStat
{
    public StatsChangeType statsChangeType;
    [Range(1f, 20f)] public float speed;
    public string name;
}