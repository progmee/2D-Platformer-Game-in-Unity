using UnityEngine;

public class FanInteraction : MonoBehaviour
{
    [SerializeField] private float fanForce = 5f;
    private Collider2D coll;
    private GameObject player;
    private Rigidbody2D rb;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Entity"))
        {
            player = collision.gameObject;
            rb = player.GetComponent<Rigidbody2D>();

            float distance = Vector2.Distance(transform.position, player.transform.position);
            
            if (distance < 0) distance = 1;
            float appliedForce = fanForce / (distance * distance) * coll.bounds.size.x * coll.bounds.size.y;

            rb.AddForce(new Vector2(rb.velocity.x, appliedForce), ForceMode2D.Impulse);
        }
    }
}
