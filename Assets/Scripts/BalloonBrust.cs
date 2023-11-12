using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBrust : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        BallonBrust();
    }

    public void BallonBrust()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);

           
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                _anim.SetTrigger("BalloonBrust");
                Debug.Log("Ballon Brust");
                Destroy(this.gameObject, 0.25f);
            }
            
        }
    }

    
}
