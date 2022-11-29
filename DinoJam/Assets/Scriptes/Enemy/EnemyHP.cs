using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hitpoints;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            hitpoints--;
            if(hitpoints <= 0)
            {
                GameController.gameController.SlayTier1Enemy();
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Trike")
        {
            hitpoints = hitpoints - 5;
            if (hitpoints <= 0)
            {
                GameController.gameController.SlayTier1Enemy();
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Pty")
        {
            hitpoints = hitpoints - 2;
            if (hitpoints <= 0)
            {
                GameController.gameController.SlayTier1Enemy();
                Destroy(gameObject);
            }
        }
    }
}
