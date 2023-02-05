using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawControl : MonoBehaviour
{
    private bool _up, _down;
    private bool _close;
    public bool _open;
    private bool _left, _right;

    Rigidbody2D _rclaw, _lclaw;
    // Start is called before the first frame update
    void Start()
    {
        _rclaw = GameObject.Find("right claw").GetComponent<Rigidbody2D>();
        _lclaw = GameObject.Find("left claw").GetComponent<Rigidbody2D>();
        _open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _down = true;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            _down = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _up = true;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _up = false; 
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _left = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _left = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _right = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _right = false; 
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _open = !_open; 
        }

        if (_up)
        {
            gameObject.transform.Translate(0,-0.01f, 0);
        }

        if (_down)
        {
            gameObject.transform.Translate(0, 0.01f,0);
        }

        if (_right)
        {
            gameObject.transform.Translate(0.01f, 0,0);
        }

        if (_left)
        {
            gameObject.transform.Translate(-0.01f, 0,0);
        }

        if (_open)
        {
            
            if (_lclaw.transform.eulerAngles.z > 300)
            {
                _lclaw.transform.Rotate(0,0,1f);
            }
            if(_lclaw.transform.eulerAngles.z < 60)
            {
                _lclaw.transform.Rotate(0,0,1f);
            }

            if (!_open)
            {
                if (_rclaw.transform.eulerAngles.z > 300)
                {
                    _rclaw.transform.Rotate(0, 0, -1f);
                }

                if (_rclaw.transform.eulerAngles.z < 60)
                {
                    _rclaw.transform.Rotate(0, 0, 1f);
                }
            }
        }
    }
}
