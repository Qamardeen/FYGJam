using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoCharge : MonoBehaviour
{
    public Transform lookDirection;
    public float speed;
    public float decayTime;

    Vector3 moveVec;

    // Start is called before the first frame update
    void Start()
    {
        lookDirection = GameObject.Find("FirePoint").transform;
        moveVec = lookDirection.up * speed * Time.fixedDeltaTime;
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(moveVec);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(decayTime);
        Destroy(gameObject);
    }
}