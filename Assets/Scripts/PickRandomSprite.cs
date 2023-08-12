using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomSprite : MonoBehaviour
{
    public Sprite[] spriteOptions;
    private int randomIndex;

    private void Awake()
    {
        randomIndex = Random.Range(0, spriteOptions.Length);
        SetRandomSprite();
    }

    public void SetRandomSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer != null && randomIndex < spriteOptions.Length)
        {
            spriteRenderer.sprite = spriteOptions[randomIndex];
        }
    }
}


