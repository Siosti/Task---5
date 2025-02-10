using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float moveDir;
    public float moveSpeed;
    public float stop;
    public float Rotationspeed;
    public bool rotate;
    private void Update()
    {
        if(moveDir != 0)
        transform.position += new Vector3(0,moveDir * moveSpeed,0);
        if (transform.position.y >= stop || transform.position.y <= -stop) moveDir = 0;
        if(rotate) transform.Rotate(0, Rotationspeed*Time.deltaTime, 0);
    }

    public void MoveUp()
    {
        /* moveDir = 1;
         if (transform.position.y >= stop || transform.position.y <= -stop) moveDir = 0;*/
        gameObject.SetActive(true);
    }
    public void MoveDowv()
    {
       /* moveDir = -1;
        if (transform.position.y >= stop || transform.position.y <= -stop) moveDir = 0;*/
       gameObject.SetActive(false);
    }
}
