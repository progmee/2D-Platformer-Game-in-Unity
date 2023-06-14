using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishAudioEffect;
    private bool alreadyFinished = false;

    private void Start()
    {
        finishAudioEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Entity"))
        {
            if (!alreadyFinished)
            {
                finishAudioEffect.Play();
                alreadyFinished = true;

                Invoke("CompleteLevel", 1f);
            }
        }
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
