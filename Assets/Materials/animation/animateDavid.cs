using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateDavid : MonoBehaviour
{

    public Animator ani;
    public SpriteRenderer guys;
    public Sprite[] guysArray;


    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("lol");
        
        if(collision.gameObject.transform.tag == "duck" ) {
           guys.sprite = guysArray[1];
           ani.SetTrigger("touch");
        }else if(collision.gameObject.transform.tag == "trash" ){     
           guys.sprite = guysArray[0];
           ani.SetTrigger("touch");
        }
    }
}
