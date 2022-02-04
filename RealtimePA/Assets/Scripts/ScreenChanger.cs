using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanger : MonoBehaviour
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
    {  //Quellen Screen
       SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        //zurück zum Menü
 
        SceneManager.LoadScene(0);
    }

    public void Quit()

    {
        //Programm beenden
        Application.Quit();

    }
}
