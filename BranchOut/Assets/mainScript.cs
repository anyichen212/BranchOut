using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{
    [SerializeField] int [] num;
    [SerializeField] GameObject [] tiles;
    [SerializeField] int numOfTiles;
    public static System.Random rnd = new System.Random();
    [SerializeField] private Text [] text;
    // Start is called before the first frame update

    int level1 = 0;
    void Start()
    {
        //Random rnd = new Random();
        num = new int[numOfTiles];
        for(int i = 0 ; i < numOfTiles ; i++){
            num[i] = rnd.Next(1,30); 
            text[i].GetComponent<Text>().text = num[i].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public int getHouse1(){
        return num[4];
    }

    public int getHouse2(){
        return num[1];
    }

    public int getHouse3(){
        return num[0];
    }

    public int getHouse4(){
        return num[6];
    }

    public int getHouse5(){
        return num[3];
    }

    public int getHouse6(){
        return num[2];
    }

    public int getHouse7(){
        return num[7];
    }

    public int getHouse8(){
        return num[5];
    }
}
