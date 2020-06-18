using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float magnitude;
    public float lifeTime = 3f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(0, magnitude));
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(rb.velocity.y < 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }

        if(timer > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
