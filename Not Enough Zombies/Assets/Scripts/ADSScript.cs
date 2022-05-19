using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADSScript : MonoBehaviour
{

    public Vector3 mDefaultPosition;
    public Vector3 mADSPosition;
    public Camera mCam;
    public bool isAiming;

    private void Start()
    {
        isAiming = false;
    }

    private void Update()
    {
        if (isAiming)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, mADSPosition, Time.deltaTime * 10);
            mCam.fieldOfView = Mathf.Lerp(mCam.fieldOfView, 30, 10 * Time.deltaTime);
        }
        else 
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, mDefaultPosition, 10 * Time.deltaTime);
            mCam.fieldOfView = Mathf.Lerp(mCam.fieldOfView, 60, 10 * Time.deltaTime);
        }
    }
}
