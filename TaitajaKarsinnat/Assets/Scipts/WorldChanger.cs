using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using static UnityEngine.GraphicsBuffer;


public class WorldChanger : MonoBehaviour
{
    public GameObject rightMap;
    public GameObject leftMap;
    public bool moveRightMap;
    public bool win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (win)
        {

        }
        else if (collision.CompareTag("Player") && moveRightMap)
        {
            rightMap.transform.position = new Vector2(rightMap.transform.position.x, rightMap.transform.position.y + 10.7f);
            gameObject.SetActive(false);
        }
        else if (collision.CompareTag("Player") && !moveRightMap)
        {
            leftMap.transform.position = new Vector2(leftMap.transform.position.x, leftMap.transform.position.y + 10.7f);
            gameObject.SetActive(false);
        }
    }

    //transform.position = Vector2.MoveTowards(transform.position, target, speed);
}
