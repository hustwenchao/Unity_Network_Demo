using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var hitPlayer = hit.GetComponent<PlayerMove>();
        if (hitPlayer != null)
        {
            var combat = hit.GetComponent<Combat>();
            if(combat != null)
            {
                combat.TakeDamage(10);
            }
            Destroy(gameObject);
        }
    }
}
