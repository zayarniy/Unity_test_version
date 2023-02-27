using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI ResultsText;
    public TMPro.TextMeshProUGUI IdText;
    void Start()
    {
        print("Start result");
        //ResultsText.text = "����������:"+PlayerPrefs.GetString("Results");
        ResultsText.text = "����������:" + GameManager.score;
        IdText.text = "����� ��������� ����:" + System.DateTime.Now.ToString() + " ��� ID:" + Random.Range(1, 10000);


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
