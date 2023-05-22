using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class house1 : MonoBehaviour
{
    //[SerializeField] GameObject main;
    [SerializeField] GameObject score;
    [SerializeField] Text text;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            score.GetComponent<DoNotDistroy>().setScore(text.GetComponent<Text>().text);
            SceneManager.LoadScene(2);
        }

    }
}
