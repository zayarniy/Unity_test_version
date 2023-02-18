using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI ResultsText;
    void Start()
    {
        print("Start result");
        ResultsText.text = "Результаты:"+PlayerPrefs.GetString("Results");

    }

    private void Awake()
    {
        print("Start awake");
    }

    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
