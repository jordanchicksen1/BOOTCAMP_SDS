using UnityEngine;

public class Activity03 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 300f;

    public void Boost()
    {
        rb.AddForce(Vector2.up * force);
    }
}
