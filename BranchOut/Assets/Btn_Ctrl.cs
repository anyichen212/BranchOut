using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Btn_Ctrl : MonoBehaviour
{   [SerializeField] GameObject chr;
    [SerializeField] GameObject L1L;
    [SerializeField] GameObject L1R;
    [SerializeField] GameObject L2L1;
    [SerializeField] GameObject L2R1;
    [SerializeField] GameObject L2L2;
    [SerializeField] GameObject L2R2;
    [SerializeField] GameObject L3L1;
    [SerializeField] GameObject L3R1;
    [SerializeField] GameObject L3L2;
    [SerializeField] GameObject L3R2;
    [SerializeField] GameObject L3L3;
    [SerializeField] GameObject L3R3;
    [SerializeField] GameObject L3L4;
    [SerializeField] GameObject L3R4;
    [SerializeField] GameObject L4L1;
    [SerializeField] GameObject L4L2;
    [SerializeField] GameObject L4L3;
    [SerializeField] GameObject L4L4;
    [SerializeField] GameObject L4L5;
    [SerializeField] GameObject L4L6;
    [SerializeField] GameObject L4L7;
    [SerializeField] GameObject L4L8;
    [SerializeField] GameObject L4R1;
    [SerializeField] GameObject L4R2;
    [SerializeField] GameObject L4R3;
    [SerializeField] GameObject L4R4;
    [SerializeField] GameObject L4R5;
    [SerializeField] GameObject L4R6;
    [SerializeField] GameObject L4R7;
    [SerializeField] GameObject L4R8;
    [SerializeField] TextMeshProUGUI s11;
    [SerializeField] TextMeshProUGUI s12;
    [SerializeField] TextMeshProUGUI s21;
    [SerializeField] TextMeshProUGUI s22;
    [SerializeField] TextMeshProUGUI s31;
    [SerializeField] TextMeshProUGUI s32;
    [SerializeField] TextMeshProUGUI s41;
    [SerializeField] TextMeshProUGUI s42;
    [SerializeField] TextMeshProUGUI s51;
    [SerializeField] TextMeshProUGUI s52;
    [SerializeField] TextMeshProUGUI s61;
    [SerializeField] TextMeshProUGUI s62;
    [SerializeField] TextMeshProUGUI s71;
    [SerializeField] TextMeshProUGUI s72;
    [SerializeField] TextMeshProUGUI s81;
    [SerializeField] TextMeshProUGUI s82;
    GameObject[] GL1;
    GameObject[] GR1;
    GameObject[] G2LL;
    GameObject[] G2LR;
    GameObject[] G2RL;
    GameObject[] G2RR;
    GameObject[] G31;
    GameObject[] G32;
    GameObject[] G33;
    GameObject[] G34;
    GameObject[] G35;
    GameObject[] G36;
    GameObject[] G37;
    GameObject[] G38;

    // Start is called before the first frame update
    void Start()
    { 
        GR1 = new GameObject[]{L1R,L2L2,L2R2,L3L3,L3L4,L3R3,L3R4,L4L5,L4L6,L4L7,L4L8,L4R5,L4R6,L4R7,L4R8};
        GL1 = new GameObject[]{L1L,L2L1,L2R1,L3L1,L3R1,L3L2,L3R2,L4L1,L4L2,L4L3,L4L4,L4R1,L4R2,L4R3,L4R4};
        G2LL = new GameObject[]{L2L1,L3L1,L3R1,L4L1,L4R1,L4L2,L4R2};
        G2LR = new GameObject[]{L2R1,L3L2,L3R2,L4L3,L4R3,L4R4,L4L4};
        G2RL = new GameObject[]{L2L2,L3L3,L3R3,L4L5,L4L6,L4R5,L4R6};
        G2RR = new GameObject[]{L2R2,L3L4,L3R4,L4L7,L4L8,L4R7,L4R8};
        G31 = new GameObject[]{L4L1,L4R1};
        G32 = new GameObject[]{L4L2,L4R2};
        G33 = new GameObject[]{L4L3,L4R3};
        G34 = new GameObject[]{L4L4,L4R4};
        G35 = new GameObject[]{L4L5,L4R5};
        G36 = new GameObject[]{L4L6,L4R6};
        G37 = new GameObject[]{L4L7,L4R7};
        G38 = new GameObject[]{L4L8,L4R8};
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void L1LM(){
        chr.transform.position = new Vector3(-5f, 3.7f, 0);
        L1L.SetActive(false);
        foreach (GameObject obj in GR1){
            obj.SetActive(false);
        }
    }

    public void L1RM(){
        chr.transform.position = new Vector3(5f, 3.7f, 0);
        L1R.SetActive(false);
        foreach (GameObject obj in GL1){
            obj.SetActive(false);
        }
    }

    public void L2L1M(){
        chr.transform.position = new Vector3(-7.3f, 2.3f, 0);
        L2L1.SetActive(false);
        foreach (GameObject obj in G2LR){
            obj.SetActive(false);
        }
    }

    public void L2R1M(){
        chr.transform.position = new Vector3(-2.6f, 2.3f, 0);
        L2R1.SetActive(false);
        foreach (GameObject obj in G2LL){
            obj.SetActive(false);
        }
    }

    
    public void L2L2M(){
        chr.transform.position = new Vector3(2.4f, 2.3f, 0);
        L2L2.SetActive(false);
        foreach (GameObject obj in G2RR){
            obj.SetActive(false);
        }
    }

    public void L2R2M(){
        chr.transform.position = new Vector3(7.3f, 2.3f, 0);
        L2R2.SetActive(false);
        foreach (GameObject obj in G2RL){
            obj.SetActive(false);
        }
    }

    public void L3L1M(){
        chr.transform.position = new Vector3(-8.8f, 1f, 0);
        L3L1.SetActive(false);
        L3R1.SetActive(false);
        foreach (GameObject obj in G32){
            obj.SetActive(false);
        }
    }

    public void L3R1M(){
        chr.transform.position = new Vector3(-6.3f, 1f, 0);
        L3R1.SetActive(false);
        L3L1.SetActive(false);
        foreach (GameObject obj in G31){
            obj.SetActive(false);
        }
    }

    public void L3L2M(){
        chr.transform.position = new Vector3(-3.8f, 1f, 0);
        L3L2.SetActive(false);
        L3R2.SetActive(false);
        foreach (GameObject obj in G34){
            obj.SetActive(false);
        }
    }

    public void L3R2M(){
        chr.transform.position = new Vector3(-1.1f, 1f, 0);
        L3R2.SetActive(false);
        L3L2.SetActive(false);
        foreach (GameObject obj in G33){
            obj.SetActive(false);
        }
    }
    public void L3L3M(){
        chr.transform.position = new Vector3(1.1f, 1f, 0);
        L3L3.SetActive(false);
        L3R3.SetActive(false);
        foreach (GameObject obj in G36){
            obj.SetActive(false);
        }
    }

    public void L3R3M(){
        chr.transform.position = new Vector3(3.5f, 1f, 0);
        L3R3.SetActive(false);
        L3L3.SetActive(false);
        foreach (GameObject obj in G35){
            obj.SetActive(false);
        }
    }

    public void L3L4M(){
        chr.transform.position = new Vector3(6.15f, 1f, 0);
        L3L4.SetActive(false);
        L3R4.SetActive(false);
        foreach (GameObject obj in G38){
            obj.SetActive(false);
        }
    }

    public void L3R4M(){
        chr.transform.position = new Vector3(8.5f, 1f, 0);
        L3R4.SetActive(false);
        L3L4.SetActive(false);
        foreach (GameObject obj in G37){
            obj.SetActive(false);
        }
    }

    public void L4L1M(){
        chr.transform.position = new Vector3(-8.8f, -1.2f, 0);
    }

    public void L4L2M(){
        chr.transform.position = new Vector3(-6.3f, -1.2f, 0);
    }

    public void L4L3M(){
        chr.transform.position = new Vector3(-3.8f, -1.2f, 0);
    }

    public void L4L4M(){
        chr.transform.position = new Vector3(-1.1f, -1.2f, 0);
    }

    public void L4L5M(){
        chr.transform.position = new Vector3(1.1f, -1.2f, 0);
    }

    public void L4L6M(){
        chr.transform.position = new Vector3(3.5f, -1.2f, 0);
    }

    public void L4L7M(){
        chr.transform.position = new Vector3(6.1f, -1.2f, 0);
    }

    public void L4L8M(){
        chr.transform.position = new Vector3(8.5f, -1.2f, 0);
    }

    public void L4R1M(){
        chr.transform.position = new Vector3(-8.8f, -3.44f, 0);
    }

    public void L4R2M(){
        chr.transform.position = new Vector3(-6.3f, -3.44f, 0);
    }

    public void L4R3M(){
        chr.transform.position = new Vector3(-3.8f, -3.44f, 0);
    }

    public void L4R4M(){
        chr.transform.position = new Vector3(-1.1f, -3.44f, 0);
    }

    public void L4R5M(){
        chr.transform.position = new Vector3(1.1f, -3.44f, 0);
    }

    public void L4R6M(){
        chr.transform.position = new Vector3(3.5f, -3.44f, 0);
    }

    public void L4R7M(){
        chr.transform.position = new Vector3(6.1f, -3.44f, 0);
    }   

    public void L4R8M(){
        chr.transform.position = new Vector3(8.5f, -3.44f, 0);
    }
    


}
