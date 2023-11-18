using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCo : MonoBehaviour
{
    private int mushroom = 0;

    [SerializeField] private Text mushroomText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mushroom"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            mushroom++;
            mushroomText.text = "NẤM: " + mushroom;
        }
    }
}
