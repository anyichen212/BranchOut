using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Game_Controller : MonoBehaviour
{   [SerializeField] GameObject overlay;
    [SerializeField] GameObject pause;
    


    // Start is called before the first frame update
    void Start()
    { 
       overlay.SetActive(false);
       Time.timeScale = 1.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause(){
       overlay.SetActive(true);
       pause.SetActive(false);
       Time.timeScale = 0.0f;

    }

    public void Resume(){
        Time.timeScale = 1.0f;
        overlay.SetActive(false);
        pause.SetActive(true);


    }

    public void Menu(){
        SceneManager.LoadScene("startmenu");
    }


}
