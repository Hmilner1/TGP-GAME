using UnityEngine;


public class Recoil : MonoBehaviour
{
    //recoil rotation
    private Vector3 mCurrentRotation;
    private Vector3 mEndRotation;

    private CurrentWeapon currWeapon;

    private void Awake()
    {
        currWeapon = GameObject.Find("Weapon01").GetComponent<CurrentWeapon>();
    }

    void FixedUpdate()
    {
        //Calculate recoil
        mEndRotation = Vector3.Lerp(mEndRotation, Vector3.zero, currWeapon.mRecoilSpeed * Time.deltaTime);
        mCurrentRotation = Vector3.Slerp(mCurrentRotation, mEndRotation, currWeapon.mSnappiness * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(mCurrentRotation);
    }

    public void ApplyRecoil()
    {
        mEndRotation += new Vector3(currWeapon.mRecoilX, Random.Range(-currWeapon.mRecoilY, currWeapon.mRecoilY), Random.Range(-currWeapon.mRecoilZ, currWeapon.mRecoilZ));
    }
}
