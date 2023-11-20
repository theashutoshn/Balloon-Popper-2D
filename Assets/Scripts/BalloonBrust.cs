using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBrust : MonoBehaviour
{
    private Animator _anim;

    [SerializeField]
    private AudioClip _popClip;

    public UIManager _ui;

    void Start()
    {
        _anim = GetComponent<Animator>();
        if (_anim == null)
        {
            Debug.Log("Animation is Null");
        }
        _ui = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        BrustSystem();
    }

    public void BrustSystem()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);

           
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                _anim.SetTrigger("BalloonBrust");
                AudioSource.PlayClipAtPoint(_popClip, transform.position);
                _ui.PlayerScore();
                Debug.Log("Ballon Brust");
                Destroy(this.gameObject, 0.25f);
            }
            
        }
    }

    
}
