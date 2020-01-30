using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTrash : MonoBehaviour
{

    public GameObject wasserFlasche;
    public GameObject colaFlasche;   

    public GameObject[] go;

    float interval = 1;
    float lastTime;
    GameObject instance;
    private float randomX;
    private void create(){
        if(Time.time > lastTime + interval){
            lastTime = Time.time;
            go = new GameObject[2];
            go[0] = wasserFlasche;
            go[1] = colaFlasche;


            int r = UnityEngine.Random.Range(0, go.Length);
        
            instance = GameObject.Instantiate(go[r]);
              randomX =  UnityEngine.Random.Range(-8, 6f);
        Vector3 pos = new Vector3(randomX ,Camera.main.transform.position.y+20, Camera.main.transform.position.z + 9 );
        instance.transform.position = pos;
        } 
    }

    void Start(){
    //create();
    }
    
    // Update is called once per frame
    void Update()
    {
         create();
      
    }
}
