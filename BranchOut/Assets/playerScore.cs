using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScore : MonoBehaviour
{
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("score");
        GetComponent<Text>().text = score.GetComponent<DoNotDistroy>().getScore();
        Destroy(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
