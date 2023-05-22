using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level1left : MonoBehaviour
{
    [SerializeField] GameObject right;
    [SerializeField] GameObject left;
    [SerializeField] GameObject main;

    [SerializeField] GameObject rightCanvas1;
    [SerializeField] GameObject rightCanvas2;
    [SerializeField] GameObject leftCanvas1;
    [SerializeField] GameObject leftCanvas2;

    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    int bigger = 0;
    int drop = 0; //false = left, true = right
    // Start is called before the first frame update

    int score1;
    int score2;
    int score3;
    int score4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(drop == 2){
            Destroy(rightCanvas1);
            Destroy(rightCanvas2);
            right.transform.Translate(0 , -2*Time.deltaTime,0);
        }

        if(drop == 1){
            Destroy(leftCanvas1);
            Destroy(leftCanvas2);
            left.transform.Translate(0 , -2*Time.deltaTime,0);
        }
        
    if(right != null)
        if(right.transform.position.y < -10){
            Destroy(right);
            drop = 0;
            Button1.SetActive(true);
        }

    if(left != null)
        if(left.transform.position.y < -10){
            Destroy(left);
            drop = 0;
            Button2.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score1 = main.GetComponent<mainScript>().getHouse1();
        score2 = main.GetComponent<mainScript>().getHouse2();
        score3 = main.GetComponent<mainScript>().getHouse3();
        score4 = main.GetComponent<mainScript>().getHouse4();
                Debug.Log(score1 + "" + score2 + " " + score3 + " " +score4);
        
        if(collision.gameObject.tag == "Player")
        {
            if(score1 > bigger){
                bigger = score1;
                drop = 1;
            }

            if(score2 > bigger){
                bigger = score2;
                drop = 1;
            }

            if(score3 > bigger){
                bigger = score3;
                drop = 2;
            }

            if(score4 > bigger){
                bigger = score4;
                drop = 2;
            }
        }

    }
}
