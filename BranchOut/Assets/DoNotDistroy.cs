using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDistroy : MonoBehaviour
{
    string score;
    private void Awake() {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("score");
        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void setScore(string s){
        score = s;
        Debug.Log(score);
    }

    public string getScore(){
        return score;
    }
}