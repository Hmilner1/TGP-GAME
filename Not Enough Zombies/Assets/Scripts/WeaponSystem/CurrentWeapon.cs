using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon: Weapon 
{

    [SerializeField]
    private Weapons CurrentGun;
    private Vector2 mSpread;
    private MeshFilter m_GunMesh;
    private MeshRenderer m_MeshRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        m_GunMesh = GameObject.Find("Weapon01").GetComponent<MeshFilter>();
        m_MeshRenderer = GameObject.Find("Weapon01").GetComponent<MeshRenderer>();
        // WeaponPos.position = Vector3.Lerp(WeaponPos.position, mDefaultPosition.localPosition, 10 * Time.deltaTime);
        mFireDelay = CurrentGun.FireDelay;
        mFireTime = CurrentGun.FireRate;
        mMagSize = CurrentGun.MagSize;
        mRange = CurrentGun.Range;
        mDamage = CurrentGun.Damage;
        //m_GunMesh.mesh = CurrentGun.GunMesh;
        mName = CurrentGun.WeaponName;
        mReloadTime = CurrentGun.ReloadTime;
        

        mRecoilX = CurrentGun.mRecoilX;
        mRecoilY = CurrentGun.mRecoilY;
        mRecoilZ = CurrentGun.mRecoilZ;

        mSnappiness = CurrentGun.mSnappiness;
        mRecoilSpeed = CurrentGun.mRecoilSpeed;
        //mIsFullAuto = false;
        // mWeaponName = WeaponNames.Shotgun;
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
            isReloading = false;
            string swapName;
            CurrentWeapon NewWeapon = WeaponCheck.transform.GetComponent<CurrentWeapon>();
            swapName = NewWeapon.ReturnWeaponDetails();
            CurrentGun = Resources.Load<Weapons>("Weapons/" + swapName);
            mFireDelay = CurrentGun.FireDelay;
            mFireTime = CurrentGun.FireRate;
            mMagSize = CurrentGun.MagSize;
            mAmmo = CurrentGun.MagSize;
            mRange = CurrentGun.Range;
            mDamage = CurrentGun.Damage;
            mReloadTime = CurrentGun.ReloadTime;

            mRecoilX = CurrentGun.mRecoilX;
            mRecoilY = CurrentGun.mRecoilY;
            mRecoilZ = CurrentGun.mRecoilZ;

            mSnappiness = CurrentGun.mSnappiness;
            mRecoilSpeed = CurrentGun.mRecoilSpeed;
            m_GunMesh.mesh = CurrentGun.GunMesh;
            m_MeshRenderer.material = CurrentGun.mGunMat;
            Destroy(WeaponCheck.transform.gameObject);
        }
        base.Interact();
    }

    public string ReturnWeaponDetails()
    {
        return CurrentGun.WeaponName;
    }
}
