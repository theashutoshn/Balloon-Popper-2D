using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonMovement : MonoBehaviour
{
    private float _balloonFlySpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _balloonFlySpeed * Time.deltaTime);

        if(transform.position.y > 6.3f)
        {
            Destroy(this.gameObject);
        }
    }
}
