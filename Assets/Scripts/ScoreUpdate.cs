using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUpdate : MonoBehaviour
{
    static TextMeshProUGUI textScore;

    //static public event System.Action<int> UpdateScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void UpdateScore(int score)
    {
        GameManager.score += score;
        textScore.text = score.ToString();  
    }



    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        
    }
}
