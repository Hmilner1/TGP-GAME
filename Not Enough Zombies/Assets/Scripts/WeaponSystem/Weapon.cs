using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
public abstract class Weapon : MonoBehaviour
{

    protected enum WeaponNames
    {
        None,
        AssultRifle,
        Pistol,
        Shotgun,
        LaserRifle,
        SMG,
    }
    [SerializeField]
    private Recoil mRecoilObject;

    protected Camera m_Cam;

    [SerializeField]
    private GameObject mBulletHole;

    //Weapon Base Stats
    protected WeaponNames mWeaponName;
    public float mRange = 100.0f;
    public float mDamage = 10.0f;
    public int mAmmo;
    public int mMagSize;
    protected float mReloadTime;
    protected bool mIsFullAuto = false;
    public float mFireTime;
    public string mName;

    //Recoil variables
    protected double mFireDelay;

    //recoil coordinates
    public float mRecoilX;
    public float mRecoilY;
    public float mRecoilZ;
    public GameObject bulletHole;
    //RecoilSettings
    public float mRecoilSpeed;
    public float mSnappiness;
    public bool isReloading;

    [SerializeField] protected ParticleSystem mMuzzleFlash;
    [SerializeField] protected AudioSource mShootSound;

    private void Start()
    {
        m_Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //mRecoilObject = GameObject.Find("CameraRotation/CameraRecoil").GetComponent<Recoil>();
        mWeaponName = WeaponNames.None;
        mAmmo = mMagSize;
        isReloading = false;
    }

    protected virtual void Update()
    {

    }

    protected virtual void Shoot()
    {
        if (mAmmo > 0)
        {
            isReloading = false;
            mShootSound.pitch = UnityEngine.Random.Range(0.5f, 0.8f);
            mShootSound.Play();
            mMuzzleFlash.Play();
            mAmmo--;
            ApplyRecoil();
            RaycastHit Hit;
            if (Physics.Raycast(m_Cam.transform.position, m_Cam.transform.forward, out Hit, mRange))
            {
                Debug.Log(mAmmo);
                StartCoroutine(DespawnHole());
                TheHealth m_AIHit = Hit.transform.GetComponent<TheHealth>();
                if (m_AIHit != null)
                {
                    m_AIHit.TakeDamage(mDamage);
                    return;
                }
                bulletHole = Instantiate(mBulletHole, Hit.point, Quaternion.FromToRotation(Vector3.forward, Hit.normal));
            }
        }
    }

    public IEnumerator RapitShoot()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(mFireTime);
        }
    }

    public IEnumerator DespawnHole()
    {
        Destroy(bulletHole, 5.0f);
        yield return new WaitForSeconds(1.0f);

    }

    public virtual void Interact()
    {

    }

    protected virtual void ApplyRecoil()
    {
        //Can move ammo and recol into shoot 

        ////Fire single Shot if mouse button pressed
        //if (Input.GetButtonDown("Fire1") && mAmmo > 0)
        //{
        //    Shoot();
        //    mRecoilObject.ApplyRecoil();
        //    mAmmo--;
        //}
        //else
        //{
        //    //rapid fire if mouse button held
        //    if (Input.GetMouseButton(0) && mIsFullAuto == true)
        //    {
        //        if (mAmmo > 0)
        //        {
        //            mFireTime -= Time.deltaTime;
        //            if (mFireTime < 0)
        //            {
        //                Shoot();
        //                mRecoilObject.ApplyRecoil();
        //                //mFireTime += mFireDelay();
        //            }
        //            mAmmo--;
        //        }
        //    }
        //}

        ////reset ammo
        //if (Time.time > mFireDelay && mAmmo == 0)
        //{
        //    mAmmo = mMagSize;
        //}
        mRecoilObject.ApplyRecoil();
    }

    public void Reload()
    {
        if (isReloading == false)
        {
            isReloading = true;
            StartCoroutine(ReloadDelay());
        }
        return;
    }

    public IEnumerator ReloadDelay()
    {
        for (int i = mAmmo; i < mMagSize; i++)
        {
            mAmmo++;
            yield return new WaitForSeconds(mReloadTime);
            if (isReloading == false)
            {
                break;
            }
        }
        isReloading = false;
    }
}
