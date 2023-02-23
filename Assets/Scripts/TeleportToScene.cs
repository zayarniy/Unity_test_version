using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    public int sceneTeleport;
    public bool isRemoveTeleportAfter=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Enter");
        print(other.name);
        print(other.gameObject.tag);
        if (other.gameObject.tag =="Player")
        {
            if (isRemoveTeleportAfter) GameObject.Destroy(this.gameObject);
            SceneManager.LoadScene(sceneTeleport);
        }
    }
}
