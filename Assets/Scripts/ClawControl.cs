using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawControl : MonoBehaviour
{
    private bool _up, _down;

    private bool _left, _right; 
    // Start is called before the first frame update
    void Start()
    {
        
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

        if (_up)
        {
            gameObject.transform.Translate(0,-1f, 0);
        }

        if (_down)
        {
            gameObject.transform.Translate(0, 1f,0);
        }

        if (_right)
        {
            gameObject.transform.Translate(0.3f, 0,0);
        }

        if (_left)
        {
            gameObject.transform.Translate(-0.3f, 0,0);
        }
    }
}
