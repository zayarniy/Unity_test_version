using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{


    CanvasGroup canvasGroup;
    public int delayBeforeFade=1;
    

    // Start is called before the first frame update
    void Start()
    {
        
        canvasGroup= GetComponent<CanvasGroup>();
        //print(canvasGroup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Fade()
    {
        //Color c = renderer.GetColor();
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            //c.a = alpha;
            print(alpha);
            canvasGroup.alpha = alpha;
            
            yield return new WaitForSeconds(.1f);
        }
        this.gameObject.SetActive(false);
    }
    public void Disable()
    {
        print("Disable");

        Invoke("StartFade", delayBeforeFade);
        //this.enabled = false;    
    }

    void StartFade()
    {
        StartCoroutine(Fade());
    }
}
