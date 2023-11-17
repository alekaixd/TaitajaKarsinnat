using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool hasFlippedDown;
    private bool hasFlippedUp;
    public float forceOnGravitySwitch = 0.1f;
    void Start()
    {
        Flip();
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y < 0)
        {
            rb.gravityScale = -1;
            if (!hasFlippedDown)
            {
                if(rb.velocity.y > -5)
                {
                    rb.AddForce(transform.up * -forceOnGravitySwitch);
                    Debug.Log("Adding force" + transform.up * -forceOnGravitySwitch);
                }
                hasFlippedUp = false;
                hasFlippedDown = true;
                Flip();
            }
        }
        else
        {
            rb.gravityScale = 1;
            if (!hasFlippedUp)
            {
                if (rb.velocity.y < 5)
                {
                    Debug.Log("Adding force" + transform.up * forceOnGravitySwitch);
                    rb.AddForce(transform.up * forceOnGravitySwitch);
                }
                hasFlippedDown = false;
                hasFlippedUp = true;
                Flip();
            }
        }
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.y *= -1f;
        transform.localScale = localScale;
        AudioManager.instance.PlaySFX("Gravity");
    }
}
