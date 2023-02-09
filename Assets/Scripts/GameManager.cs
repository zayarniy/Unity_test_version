using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score  =0;

    public TMPro.TextMeshProUGUI textScore;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreUpdate(Canvas canvas)
    {
        score += 1;
        textScore.text = score.ToString();
        //canvas.enabled = false;
    }
}
