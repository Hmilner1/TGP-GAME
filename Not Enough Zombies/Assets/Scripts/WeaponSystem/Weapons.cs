using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "SO/Weapon")]
public class Weapons : ScriptableObject
{
    [Header("Weapon Name/Type")]
    public string WeaponName;
    public string WeaponType;

    [Header("Stats")]
    public float Damage;
    public float Range;
    public float ReloadTime;
    public float FireRate;
    public double FireDelay;
    public int MagSize;

    public float mRecoilX;
    public float mRecoilY;
    public float mRecoilZ;

    //RecoilSettings
    public float mRecoilSpeed;
    public float mSnappiness;

    [Header("Graphics")]
    public GameObject MuzzleFlash;
    public AudioSource ShootSound;
    public GameObject WeaponModle;
    public Mesh GunMesh;
}
