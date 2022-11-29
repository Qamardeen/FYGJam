using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PtyRage : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject dinoPrefab;

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
        if (Input.GetKeyDown(KeyCode.Alpha2) && canShoot)
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
        Instantiate(dinoPrefab, FirePoint.position, Quaternion.Euler(0, 0, 0));
        StartCoroutine(ShotCoolDown());
    }
}
