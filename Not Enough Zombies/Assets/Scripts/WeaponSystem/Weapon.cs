using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

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

    //Weapon Base Stats
    protected WeaponNames mWeaponName;
    protected float mRange = 100.0f;
    protected float mDamage = 10.0f;
    protected int mAmmo;
    protected int mMagSize;
    protected float mReloadTime;
    protected bool mIsFullAuto = false;
    protected float mFireTime;

    //Recoil variables
    protected double mFireDelay;
    
    [SerializeField] protected ParticleSystem mMuzzleFlash;
    [SerializeField] protected AudioSource mShootSound;

    private void Start()
    {
        m_Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //mRecoilObject = GameObject.Find("CameraRotation/CameraRecoil").GetComponent<Recoil>();
        mWeaponName = WeaponNames.None;
    }

    protected virtual void Update()
    {
        //Can move ammo and recol into shoot 
        /*
        Fire single Shot if mouse button pressed
        if (Input.GetButtonDown("Fire1") && mAmmo > 0)
        {
            Shoot();
            mRecoilObject.ApplyRecoil();
            mAmmo--;
        }
        else
        {
            rapid fire if mouse button held
            if (Input.GetMouseButton(0) && mIsFullAuto == true)
            {
                if (mAmmo > 0)
                {
                    mFireTime -= Time.deltaTime;
                    if (mFireTime < 0)
                    {
                        Shoot();
                        mRecoilObject.ApplyRecoil();
                        mFireTime += mFireDelay;
                    }
                    mAmmo--;
                }
            }
        }
      */

        //reset ammo
      //  if (Time.time > mFireDelay && mAmmo == 0)
       // {
       //     mAmmo = mMagSize;
      //  }
    }

    protected virtual void Shoot()
    {
        if (mAmmo > 0)
        {
            mShootSound.pitch = UnityEngine.Random.Range(0.5f, 0.8f);
            mShootSound.Play();
            mRecoilObject.ApplyRecoil();
            mMuzzleFlash.Play();
            mAmmo--;
            RaycastHit Hit;
            if (Physics.Raycast(m_Cam.transform.position, m_Cam.transform.forward, out Hit, mRange))
            {
                //Debug.Log(mAmmo);
                TheHealth m_AIHit = Hit.transform.GetComponent<TheHealth>();
                if (m_AIHit != null)
                {
                    m_AIHit.TakeDamage(mDamage);
                }
            }
        }
        else
        {
            return;
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

    public void Reload()
    {
        mAmmo = mMagSize;
    }

    public virtual void Interact()
    { 
        
    }

}
