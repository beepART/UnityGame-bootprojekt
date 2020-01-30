using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToTouchPoint : MonoBehaviour {
	
    public float speed;
    private Vector2? targetPos;

	void Update () {
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 pos = Input.mousePosition;
            targetPos = Camera.main.ScreenToWorldPoint(pos);
            Debug.Log(pos);
            Debug.Log("Screen Width : " + Screen.width);

            float middleOfScreen = Screen.width/2;
            float leftShore = Screen.width/2 - 330;
            float rightShore = Screen.width/2 + 330;
            
            Debug.Log("middle : " + middleOfScreen);
            if(pos.x >= leftShore && pos.x <= rightShore && pos.y <= 600) {
                targetPos = new Vector2(targetPos.Value.x, transform.localPosition.y);
            }else {
                targetPos = null;
            }
            
        }

        if(targetPos.HasValue)
        {
            Vector2 dir = targetPos.Value - (Vector2)transform.localPosition;
            dir.Normalize();
            float deltaSpeed = speed * Time.deltaTime;
            Vector3 movement = dir * deltaSpeed;
            transform.localPosition += movement;
            if(Mathf.Abs(transform.position.x - targetPos.Value.x) < deltaSpeed)
            {
                Vector3 newPos = transform.position;
                newPos.x = targetPos.Value.x;
                transform.position = newPos;
                targetPos = null;
            }
        }

	}
}
