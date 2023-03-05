using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float _speed;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1f )
        {
            transform.Translate(Vector3.up * (_speed * Time.deltaTime));
            Debug.Log("First");
        }
        
        if (transform.position.y > 2f)
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
