using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    public Button titleBtn;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        DataManager.Instance.LoadData();

        InfoManager.Instance.LoadInfo();
    }

    private void Start()
    {
        this.titleBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MyTitle");
        });
    }


}
