using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] AudioSource collectSoundEffect;

    [SerializeField] private Text collectedAmountText;
    private int collectedAmount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            collectSoundEffect.Play();

            Destroy(collision.gameObject);
            collectedAmount++;

            collectedAmountText.text = $": {collectedAmount}";
        }
    }
}
