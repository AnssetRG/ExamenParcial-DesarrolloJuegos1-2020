using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != this.gameObject.tag)
        {
            UIManager.instance.GainPoints(10);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == this.gameObject.tag)
        {
            UIManager.instance.LoseLife();
        }
    }
}
