using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionTab : MonoBehaviour
{
    public Button[] buttons;
    public Text[] stateText;

    public Button saveBtn;


    private Dictionary<int, MissionInfo> missionDict;

    private void Awake()
    {
        this.missionDict = new Dictionary<int, MissionInfo>();

        InfoManager.Instance.GetAllInfosByType<MissionInfo>().ForEach(x => missionDict.Add(x.id, x));
    }

    private void Start()
    {
        var missionDataList = DataManager.Instance.GetAllDatasByType<MissionData>();


        for(int i = 0; i < buttons.Length; i++)
        {
            int captured = i;
            int targetId = missionDataList[captured].id;
            stateText[captured].text = missionDict[targetId].nowGoal + " / " + missionDataList[captured].goal;
            buttons[i].onClick.AddListener(() =>
            {
                Debug.Log(captured);
                missionDict[targetId].nowGoal += 1;
                stateText[captured].text = missionDict[targetId].nowGoal + " / " + missionDataList[captured].goal;
            });
        }

        this.saveBtn.onClick.AddListener(() =>
        {
            InfoManager.Instance.SaveInfo();
            InfoManager.Instance.PrintAllInfo();
        });
    }
}
