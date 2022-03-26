using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(SpriteRenderer))]
public class HealthSpectatorUI : MonoBehaviour
{
    [SerializeField] private HealthSystem healthSystem;
    [SerializeField] private float sizeSliced;

    private SpriteRenderer sprite;
    private float sizeObjectY;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sizeObjectY = Vector2.Distance(healthSystem.transform.position, transform.position);
    }

    void Update()
    {
        transform.position = new Vector2 (healthSystem.transform.position.x, healthSystem.transform.position.y + sizeObjectY);
        Vector2 sizeSprite = new Vector2(sizeSliced * healthSystem.health / healthSystem.maxHealth, sizeSliced);
        sprite.size = sizeSprite;
    }
}
