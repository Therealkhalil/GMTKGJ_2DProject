using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(1f,0f) * speed * Time.deltaTime);
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(1*speed, rb.velocity.y);
    }
}
