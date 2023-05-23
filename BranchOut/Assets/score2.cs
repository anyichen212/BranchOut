using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score2 : MonoBehaviour
{   public string score;
    [SerializeField] GameObject scoreobj;
    // Start is called before the first frame update
    void Start()
    {score = PlayerPrefs.GetString("Score_2");
    GetComponent<Text>().text = score;


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
