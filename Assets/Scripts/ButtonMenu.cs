using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
    public Button btn;
    public Image icon;
    public Text btnName;


    public void Init(Sprite icon, string btnName)
    {
        this.icon.sprite = icon;
        this.btnName.text = btnName;
    }
}
