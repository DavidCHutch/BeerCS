using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score : MonoBehaviour
{
    public string name;
    public float gotKnifed;
    public float kills;
    public float deaths;
    public float knifed;
    public float rounds;
    public float teamKills;
    public float sips;

    public Score(string name, float gotKnifed, float kills, float deaths, float knifed, float rounds, float teamKills)
    {
        this.name = name;
        this.gotKnifed = gotKnifed;
        this.kills = kills;
        this.deaths = deaths;
        this.knifed = knifed;
        this.rounds = rounds;
        this.teamKills = teamKills;
        this.sips = deaths + (kills * 2) + (teamKills * 20);
    }
}
