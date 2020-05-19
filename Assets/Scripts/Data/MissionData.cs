using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionData : RawData
{
    public int goal;

    public int reward_type;

    public int reward_count;

    public string icon_name;

    public string desc;

    public MissionData(int id, int reward_type, int reward_count, string icon_name, string desc) : base(id)
    {
        this.reward_type = reward_type;
        this.reward_count = reward_count;
        this.icon_name = icon_name;
        this.desc = desc;
    }
}
