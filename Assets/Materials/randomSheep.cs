using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSheep : MonoBehaviour
{
    public GameObject sheep; 
    public GameObject[] go;

    float interval = 1;
    float lastTime;
    GameObject instance;
    private float randomX;
    private void create(){
        if(Time.time > lastTime + interval){
            lastTime = Time.time;
            go = new GameObject[1];
            go[0] = sheep;
            int r = UnityEngine.Random.Range(0, go.Length);
            
            float middleOfScreen = Screen.width/2;
            float leftShore = Screen.width/2 - 350;
            float rightShore = Screen.width/2 + 350;
            instance = GameObject.Instantiate(go[r]);
            randomX =  UnityEngine.Random.Range(-25, 28);
            
            if(randomX < 8 ) {
                randomX =  UnityEngine.Random.Range(8, 28);
            }else if(randomX > -15){
                randomX =  UnityEngine.Random.Range(-25, -15);
            }
            
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
