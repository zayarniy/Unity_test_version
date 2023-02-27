using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static int score = 0;

    public TMPro.TextMeshProUGUI textScore;

    //public Canvas scoreCanvas;

    private static GameManager instance;
    public static GameManager Instance => instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance)
        {
            DestroyImmediate(instance);
            return;
        }
        instance= this;
        SimpleCollectibleScript.ScoreUpdate += ScoreUpdate;
        textScore= GameObject.FindObjectsOfType<TextMeshProUGUI>().FirstOrDefault(obj=>obj.name=="Score");
        print(textScore);
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreUpdate(int score=1)
    {
        GameManager.score += score;
        print(System.DateTime.Now);
        //print(textScore);
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
