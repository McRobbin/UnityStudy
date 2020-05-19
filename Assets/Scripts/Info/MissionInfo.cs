using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionInfo : RawInfo
{
    public int nowGoal;
    public bool isRewarded;

    public MissionInfo(int id, int nowGoal = 0, bool isRewarded = false) : base(id)
    {
        this.nowGoal = nowGoal;
        this.isRewarded = isRewarded;
    }
}
