using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    public int hitpoints;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hitpoints--;
            if (hitpoints <= 0)
            {
                GameController.gameController.SlayBossEnemy();
                Destroy(gameObject);
            }
        }
    }
}
