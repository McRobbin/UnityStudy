using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

public class DataManager
{
    private static DataManager dataManager;
    private static Dictionary<int, RawData> dataDict;

    public static DataManager Instance
    {
        get
        {
            if (dataManager == null)
                dataManager = new DataManager();
            return dataManager;
        }
    }

    private DataManager()
    {
        dataDict = new Dictionary<int, RawData>();
    }

    public void LoadData()
    {
        JsonConvert.DeserializeObject<MissionData[]>(Resources.Load<TextAsset>("Data/mission_data").text)
            .ToList().ForEach(x => dataDict.Add(x.id, x));

    }

    public T GetDataById<T>(int id) where T : RawData
    {
        return dataDict[id] as T;
    }

    public List<int> GetAllId()
    {
        return dataDict.Keys.ToList();
    }

    public List<T> GetAllDatasByType<T>() where T : RawData
    {
        return dataDict.Values.OfType<T>().ToList();
    }

    public void PrintAllData()
    {
        foreach(var data in dataDict.Values.OfType<MissionData>())
        {
            Debug.Log(data.id + " " + data.goal + " " + data.reward_count);
        }
    }
}
