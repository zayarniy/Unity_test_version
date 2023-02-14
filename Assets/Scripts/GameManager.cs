using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score  =0;

    public TMPro.TextMeshProUGUI textScore;
    //public Canvas scoreCanvas;
    

    // Start is called before the first frame update
    void Start()
    {
        SimpleCollectibleScript.ScoreUpdate += ScoreUpdate;
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreUpdate(int score=1)
    {
        this.score += score;
        print(System.DateTime.Now);
        textScore.text = this.score.ToString();
        //canvas.enabled = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
