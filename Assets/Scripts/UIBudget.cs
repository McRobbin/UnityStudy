using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBudget : MonoBehaviour
{
    public Image budgetIcon;
    public Text countText;
    public Button addBtn;

    public void Init(Sprite icon, string count)
    {
        this.budgetIcon.sprite = icon;
        this.countText.text = count;
    }
}
