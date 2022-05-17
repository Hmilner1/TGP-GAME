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

    //recoil coordinates
    public float mRecoilX;
    public float mRecoilY;
    public float mRecoilZ;

    //RecoilSettings
    public float mRecoilSpeed;
    public float mSnappiness;

    //other weapon stats
   /// protected float mHoleTime;

    [SerializeField] protected ParticleSystem mMuzzleFlash;
    [SerializeField] protected AudioSource mShootSound;

    private void Start()
    {
        m_Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //mRecoilObject = GameObject.Find("CameraRotation/CameraRecoil").GetComponent<Recoil>();
        mWeaponName = WeaponNames.None;
        mAmmo = mMagSize;
    }

    protected virtual void Update()
    {
       
    }

    protected virtual void Shoot()
    {
        if (mAmmo > 0)
        {
            Debug.Log("Runnning");
            mShootSound.pitch = UnityEngine.Random.Range(0.5f, 0.8f);
            mShootSound.Play();
            mMuzzleFlash.Play();
            ApplyRecoil();
            RaycastHit Hit;
            if (Physics.Raycast(m_Cam.transform.position, m_Cam.transform.forward, out Hit, mRange))
            {
                Debug.Log(mAmmo);
                TheHealth m_AIHit = Hit.transform.GetComponent<TheHealth>();
                if (m_AIHit != null)
                {
                    m_AIHit.TakeDamage(mDamage);
                }
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

    public virtual void Interact()
    { 
        
    }

    protected virtual void ApplyRecoil()
    { 
        mRecoilObject.ApplyRecoil();
    }

//    protected virtual void BulletHole
//    {
            
//    }
}
