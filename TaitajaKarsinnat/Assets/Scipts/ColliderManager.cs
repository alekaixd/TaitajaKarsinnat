using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    public float osuiko = 0;
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.tag == "TriggerLeft")
            {
                Instantiate(myPrefab, new Vector2(-5, 0), Quaternion.identity);
                Debug.Log("Osui vasempaan");
                osuiko += 1;
            }
            else if (gameObject.tag == "TriggerRight")
            {
                Instantiate(myPrefab, new Vector2(0, 0), Quaternion.identity);
                Debug.Log("Osui Oikeaan");
                osuiko += 1;
            }
            

            Debug.Log(osuiko);
        }
        

    }
}
