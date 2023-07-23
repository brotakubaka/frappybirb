using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float leftBound = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyPipes();
    }

    void DestroyPipes()
    {
        if (gameObject.transform.position.x < leftBound)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted");
        }
    }
}
