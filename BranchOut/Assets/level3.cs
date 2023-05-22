using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3 : MonoBehaviour
{
    //[SerializeField] GameObject main;
    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            Button1.SetActive(true);
            Button2.SetActive(true);
        }

    }
}
