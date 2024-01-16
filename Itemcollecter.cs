using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemcollecter : MonoBehaviour
{
    private int Strawberry = 0;

    [SerializeField] private Text candiesText;
    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            Strawberry++;
            collectSoundEffect.Play();
            candiesText.text = "Candy Canes: " + Strawberry;
           
        }
    }
    
}
