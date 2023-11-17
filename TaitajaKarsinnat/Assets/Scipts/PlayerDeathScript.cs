using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Destroy(gameObject);
        }
    }
}
