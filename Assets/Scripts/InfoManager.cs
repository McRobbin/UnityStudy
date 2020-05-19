using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Newtonsoft.Json;
using System.Linq;

public class InfoManager
{
    private static InfoManager infoManager;
    private Dictionary<int, RawInfo> infoDict;
    public static InfoManager Instance
    {
        get
        {
            if (infoManager == null)
                infoManager = new InfoManager();
            return infoManager;
        }
    }

    private InfoManager()
    {
        infoDict = new Dictionary<int, RawInfo>();
    }

    public void LoadInfo()
    {
        if(File.Exists(Application.persistentDataPath + "/mission_info.json"))
        {
            JsonConvert.DeserializeObject<Dictionary<int, MissionInfo>>(File
                .ReadAllText(Application.persistentDataPath + "/mission_info.json"))
                .ToList().ForEach(x => infoDict.Add(x.Key, x.Value));
            Debug.Log("Info 불러오기");
        }

        else
        {
            DataManager.Instance.GetAllId().ForEach(x => infoDict.Add(x, new MissionInfo(x)));
            this.SaveInfo();
        }
    }

    public void SaveInfo()
    {
        File.WriteAllText(Application.persistentDataPath + "/mission_info.json",
            JsonConvert.SerializeObject(infoDict));
        Debug.Log(Application.persistentDataPath);
        Debug.Log("Info 세이브");
    }

    public List<T> GetAllInfosByType<T>() where T : RawInfo
    {
        return infoDict.Values.OfType<T>().ToList();
    }

    public T GetDataById<T>(int id) where T : RawInfo
    {
        return infoDict[id] as T;
    }

    public void PrintAllInfo()
    {
        foreach(var info in infoDict.Values.OfType<MissionInfo>())
        {
            Debug.Log(info.id + " " + info.nowGoal);
        }
    }
}
