using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Hero>(out Hero hero))
        {
            SpriteRenderer spriteRenderer = collision.GetComponent<SpriteRenderer>();
            
            if(spriteRenderer.flipX == false)
                spriteRenderer.flipX = true;
            else
                spriteRenderer.flipX = false;
        }
    }
}
