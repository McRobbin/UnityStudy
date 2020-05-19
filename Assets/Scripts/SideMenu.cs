using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideMenu : MonoBehaviour
{
    public Sprite sideIcon;
    public Button btn;

    public void Init(Sprite sprite)
    {
        this.sideIcon = sprite;
    }
}
