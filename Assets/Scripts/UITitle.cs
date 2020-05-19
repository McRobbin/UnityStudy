using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum eMenuType
{
    Items,
    Shop,
    Messages,
    Mission,
    Ranking,
    Settings
}

public class UITitle : MonoBehaviour
{
    public ButtonMenu[] btnMenu;
    public Sprite[] menuIcon;

    public bool showNotiShop;
    public GameObject notiShopIconGo;

    public bool showNotiMission;
    public GameObject notiMissionIconGo;

    public int mailCount;
    public UITitleNotiMessage uiTitleNotiMessage;

    public Button btnStart;

    public UIBudget[] uiBudget;
    public Sprite[] budgetIcon;
    public string[] budgetText;

    public Button friendBtn;
    public Button facebookBtn;
 
    private void Start()
    {
        this.uiTitleNotiMessage.Init(this.mailCount);

        if (this.showNotiShop) this.notiShopIconGo.SetActive(true);
        else this.notiShopIconGo.SetActive(false);

        if (this.showNotiMission) this.notiMissionIconGo.SetActive(true);
        else this.notiMissionIconGo.SetActive(false);

        if (this.mailCount > 0) this.uiTitleNotiMessage.Show();
        else this.uiTitleNotiMessage.Hide();

        for(int i = 0; i < btnMenu.Length; i++)
        {
            int captured = i;
            btnMenu[captured].Init(menuIcon[captured], ((eMenuType)captured).ToString());

            btnMenu[captured].btn.onClick.AddListener(() =>
            {
                switch ((eMenuType)captured)
                {
                    case eMenuType.Mission:
                        SceneManager.LoadScene("MissionTab");
                        break;
                }
            });
        }

        this.btnStart.onClick.AddListener(() =>
        {
            Debug.Log("Start");
        });

        for(int i = 0; i < uiBudget.Length; i++)
        {
            int captured = i;
            uiBudget[captured].Init(this.budgetIcon[captured], budgetText[captured]);

            uiBudget[captured].addBtn.onClick.AddListener(() =>
            {
                Debug.Log(this.uiBudget[captured].countText.text);
            });
        }


        this.friendBtn.onClick.AddListener(() =>
        {
            Debug.Log("친구 버튼");
        });

        this.facebookBtn.onClick.AddListener(() =>
        {
            Debug.Log("페이스북 버튼");
        });

    }
}
