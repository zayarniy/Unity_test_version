using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score  =0;

    public TMPro.TextMeshProUGUI textScore;
    //public Canvas scoreCanvas;
    

    // Start is called before the first frame update
    void Awake()
    {
        SimpleCollectibleScript.ScoreUpdate += ScoreUpdate;
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreUpdate(int score=1)
    {
        GameManager.score += score;
        print(System.DateTime.Now);
        print(textScore);
        textScore.text = GameManager.score.ToString();
        //canvas.enabled = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void ScoreScene()
    {
        SceneManager.LoadScene("Results");
        PlayerPrefs.SetString("Results", string.Join("\n", GameManager.score));
    }





}
