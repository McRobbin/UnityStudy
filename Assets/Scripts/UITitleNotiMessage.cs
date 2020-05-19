using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITitleNotiMessage : MonoBehaviour
{
    public GameObject bg;
    public Text mailCount;

    public void Init(int mailCount)
    {
        this.mailCount.text = mailCount.ToString();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);

    }
}
