using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private PokemonBase _base;
    private int _level;

    public Pokemon(PokemonBase pBase, int level)
    {
        _base = pBase;
        _level = level;
    }

    public int Level => _level;
    public PokemonBase Base => _base;

    public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100f) + 5;
    public int Defence => Mathf.FloorToInt((_base.Defence * _level) / 100f) + 5;
    public int MaxHp => Mathf.FloorToInt((_base.MaxHp * _level) / 100f) + 10;
    public int SpAttack => Mathf.FloorToInt((_base.SpAttack * _level) / 100f) + 5;
    public int SpDefence => Mathf.FloorToInt((_base.SpDefence * _level) / 100f) + 5;
    public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100f) + 5;
}
