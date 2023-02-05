using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawMovement : MonoBehaviour
{
    private static ClawMovement instance;

    public static ClawMovement Instance
    {
        get
        {
            if(instance==null)
            {
                instance = new ClawMovement();
            }
            return instance;
        }
    }

    public float angle;
    public bool isLeft, isPlaying;

    public bool isCo = false;

    void FixedUpdate()
    {
        angle = transform.localEulerAngles.z;
        angle = (angle > 180) ? angle - 360 : angle;

        if (isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                StartCoroutine(_Tighten());
            
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
                StartCoroutine(_Untie());
            
        }

    }
    void Awake()
    {
        isPlaying = true;
    }

    //void Tighten()
    //{
    //    if (isLeft)
    //    {
    //        if (angle > -13f && angle <= 43f)
    //            transform.Rotate(0, 0, 2f);
    //    }
    //    else
    //    {
    //        if (angle < 13f && angle >= -43f)
    //            transform.Rotate(0, 0, -2f);
    //    }
    //}

    //void Untie()
    //{
    //    if (isLeft)
    //    {
    //        if (angle > -11f && angle < 45f)
    //            transform.Rotate(0, 0, -2f);
    //    }
    //    else
    //    {
    //        if (angle < 11f && angle > -45f)
    //            transform.Rotate(0, 0, 2f);
    //    }
    //}
    public IEnumerator _Tighten()
    {
        isCo = true;

        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            if (isLeft)
            {
                if (angle > -13f && angle <= 43f)
                    transform.Rotate(0, 0, 2f);
                else
                {
                    isPlaying = false;
                    //MobileMovementManager.instance.tightn = false;
                    break;
                }

            }
            else
            {
                if (angle < 13f && angle >= -43f)
                    transform.Rotate(0, 0, -2f);
                else
                {
                    //MobileMovementManager.instance.tightn = false;
                    isPlaying = false;
                    break;
                }
            }
        }
        isCo = false;
    }
    public IEnumerator _Untie()
    {
        isCo = true;
        Debug.Log("asdfasdfasdfasdfasdf     1");
        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            if (isLeft)
            {
                if (angle > -11f && angle < 45f)
                    transform.Rotate(0, 0, -2f);
                else
                {
                    //MobileMovementManager.instance.tightn = true;
                    isPlaying = true;
                    break;
                }

            }
            else
            {
                if (angle < 11f && angle > -45f)
                    transform.Rotate(0, 0, 2f);
                else
                {
                    //MobileMovementManager.instance.tightn = true;
                    isPlaying = true;
                    break;
                }
            }
        }
        isCo = false;
    }
}