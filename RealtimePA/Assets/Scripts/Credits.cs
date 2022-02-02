using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagment;

public class Credits : MonoBehaviour
{
    public float textspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Scroll nach oben
        transform.position = transform.position + new Vector3 (0,textspeed,0)*Time.deltaTime;
    }

    public void OpenCredit()
    {
       // SceneManager.LoadScene(1);
    }
}
