using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPickups : MonoBehaviour
{
    [SerializeField] AudioClip diamondPickupSFX;
    [SerializeField] int diamondValue = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(diamondPickupSFX, Camera.main.transform.position);
        FindObjectOfType<GameSession>().AddToScore(diamondValue);
        Destroy(gameObject);
    }
}
