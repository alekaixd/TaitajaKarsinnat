using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class WorldChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    public Vector2 target = new Vector2(0, 0);

    public ColliderManager colliderManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //target.x = target.x * -1;
        //}


        if(/*colliderManager.osuiko % 2 == 0 &&*/ colliderManager.osuiko != 0) { 
        transform.position = Vector2.MoveTowards(transform.position, target, speed);
        
            //System.Threading.Thread.Sleep(2300);


            //Destroy(gameObject);
        }
    }
}
