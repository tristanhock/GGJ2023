using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawControl : MonoBehaviour
{
    private bool _up, _down;
    private bool _close;
    public bool _open;
    private bool _left, _right;
    
    public float openSpeed = 1.0f; // Speed at which the claw opens
    public float closeSpeed = 1.0f; // Speed at which the claw closes
    

    public bool isClawOpen = false; // Keeps track of whether the claw is open or closed
    private float currentClawOpen = 0.0f; // Keeps track of the current claw open distance
    public Transform _lclawopen, _lclawclose, _rclawopen, _rclawclose;
    public Transform _rclaw, _lclaw;

    // Start is called before the first frame update
    void Start()
    {
        
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
            isClawOpen = !isClawOpen;
        }

        if (_up)
        {
            gameObject.transform.Translate(0, -0.01f, 0);
        }

        if (_down)
        {
            gameObject.transform.Translate(0, 0.01f, 0);
        }

        if (_right)
        {
            gameObject.transform.Translate(0.01f, 0, 0);
        }

        if (_left)
        {
            gameObject.transform.Translate(-0.01f, 0, 0);
        }

        // if (_open)
        // {
        //     Debug.Log("left claw" + _lclaw.transform.eulerAngles);
        //     Debug.Log("right claw" + _rclaw.transform.eulerAngles);
        //     if (_lclaw.transform.eulerAngles.z > 300)
        //     {
        //         _lclaw.transform.Rotate(0, 0, 1f);
        //     }
        //
        //     if (_lclaw.transform.eulerAngles.z < 60)
        //     {
        //         _lclaw.transform.Rotate(0, 0, 1f);
        //     }
        // }
        //
        // if (!_open)
        // {
        //     if (_rclaw.transform.eulerAngles.z > 300)
        //     {
        //         _rclaw.transform.Rotate(0, 0, -1f);
        //     }
        //
        //     if (_rclaw.transform.eulerAngles.z < 60)
        //     {
        //         _rclaw.transform.Rotate(0, 0, 1f);
        //     }
        // }




        // Check if the claw should be open or closed
        if (isClawOpen)
        {
            _lclaw.transform.rotation = Quaternion.Lerp(_lclaw.rotation, _lclawopen.rotation, openSpeed * Time.deltaTime);
            _rclaw.transform.rotation = Quaternion.Lerp(_rclaw.rotation, _rclawopen.rotation, openSpeed * Time.deltaTime);
        }
        
        else
        {
            _lclaw.transform.rotation = Quaternion.Lerp(_lclaw.rotation, _lclawclose.rotation, openSpeed * Time.deltaTime);
            _rclaw.transform.rotation = Quaternion.Lerp(_rclaw.rotation, _rclawclose.rotation, openSpeed * Time.deltaTime);
        }

        // Apply the claw open distance to the claw object
        //claw.localPosition = new Vector3(0.0f, currentClawOpen, 0.0f);

    }

    public void OpenClaw()
    {
        isClawOpen = true;
    }

    public void CloseClaw()
    {
        isClawOpen = false;
    }
}
      
    
