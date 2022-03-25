using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class AnimationController : MonoBehaviour
{
    [SerializeField] private Sprite[] spritesNormal;
    [SerializeField] private Sprite[] spritesDirty;
    [SerializeField] private Sprite[] spritesAngry;

    private Sprite[] nowSprites;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        nowSprites = spritesNormal;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void MoveUp()
    {
        spriteRenderer.sprite = nowSprites[0];
    }

    public void MoveLeft()
    {
        spriteRenderer.sprite = nowSprites[1];
    }

    public void MoveDown()
    {
        spriteRenderer.sprite = nowSprites[2];
    }

    public void MoveRight()
    {
        spriteRenderer.sprite = nowSprites[3];
    }

    public void Normal()
    {
        nowSprites = spritesNormal;
    }

    public void Angry()
    {
        nowSprites = spritesAngry;
    }

    public void Hit()
    {
        nowSprites = spritesDirty;
    }
}
