using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon: Weapon 
{
    [SerializeField]
    private Weapons CurrentGun;
    private Vector2 mSpread;
    // Start is called before the first frame update
    void Awake()
    {
        mFireDelay = CurrentGun.FireDelay;
        mFireTime = CurrentGun.FireRate;
        mMagSize = CurrentGun.MagSize;
        mRange = CurrentGun.Range;
        mDamage = CurrentGun.Damage;

        mRecoilX = CurrentGun.mRecoilX;
        mRecoilY = CurrentGun.mRecoilY;
        mRecoilX = CurrentGun.mRecoilZ;

        mSnappiness = CurrentGun.mSnappiness;
        mRecoilSpeed = CurrentGun.mRecoilSpeed;
        //mIsFullAuto = false;
        // mWeaponName = WeaponNames.Shotgun;
    }

    // Update is called once per frame
    protected override void Update()
    {
        //CurrentGun = Resources.Load<Weapons>("Weapons/");
        base.Update();
    }

    protected override void Shoot()
    {
        base.Shoot();
    }

    public override void Interact()
    {
        RaycastHit WeaponCheck;
        if (Physics.Raycast(m_Cam.transform.position, m_Cam.transform.forward, out WeaponCheck, 20))
        {
            string swapName;
            CurrentWeapon NewWeapon = WeaponCheck.transform.GetComponent<CurrentWeapon>();
            swapName = NewWeapon.ReturnWeaponDetails();
            CurrentGun = Resources.Load<Weapons>("Weapons/" + swapName);
        }
        mFireDelay = CurrentGun.FireDelay;
        mFireTime = CurrentGun.FireRate;
        mMagSize = CurrentGun.MagSize;
        mRange = CurrentGun.Range;
        mDamage = CurrentGun.Damage;

        mRecoilX = CurrentGun.mRecoilX;
        mRecoilY = CurrentGun.mRecoilY;
        mRecoilZ = CurrentGun.mRecoilZ;

        mSnappiness = CurrentGun.mSnappiness;
        mRecoilSpeed = CurrentGun.mRecoilSpeed;

        base.Interact();
    }

    public string ReturnWeaponDetails()
    {
        return CurrentGun.WeaponName;
    }
}
