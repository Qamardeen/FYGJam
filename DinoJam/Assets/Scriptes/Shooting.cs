using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    public Transform FirePoint;
    public GameObject bulletPrefab;

    public float fireRate;

    private bool canShoot;

    //public float bulletForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            
            Shoot();
        }
    }

    IEnumerator ShotCoolDown()
    {
        yield return new WaitForSeconds(fireRate);
        canShoot = true;
    }
    void Shoot()
    {
        canShoot = false;
        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        StartCoroutine(ShotCoolDown());
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
