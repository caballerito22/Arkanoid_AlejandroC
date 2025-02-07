using UnityEngine;

public class Brick : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        Destroy(gameObject);
    }
}
