using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife: MonoBehaviour
{
    [SerializeField] AudioSource deathSoundEffect;
    [SerializeField] AudioSource flewOutSoundEffect;

    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
        else if (collision.gameObject.CompareTag("Death Zone"))
        {
            Die(true);
        }
    }

    private void Die(bool isflewOut = false)
    {
        anim.SetTrigger("death");
        rb.bodyType = isflewOut ? RigidbodyType2D.Dynamic : RigidbodyType2D.Static;
        deathSoundEffect.Play();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
