using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private PlatformScript[] platScripts;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
        platScripts = new PlatformScript[platforms.Length];
        for (int i = 0; i < platforms.Length; i++)
        {
            platScripts[i] = platforms[i].GetComponent<PlatformScript>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(1f,0f) * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            Destroy(collision.gameObject);
            foreach (PlatformScript script in platScripts)
            {
                script.Nextplat++;
            }
        }
    }
}
