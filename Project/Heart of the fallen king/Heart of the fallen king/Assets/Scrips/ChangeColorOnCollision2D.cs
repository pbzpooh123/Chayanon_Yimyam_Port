using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class ChangeColorOnCollision2D : MonoBehaviour
{
    [SerializeField] private Color hitColor = Color.red;
    [SerializeField] private Color originalColor;
    [SerializeField] private SpriteRenderer charRenderer;

    // ������Ŵ�����Ѻ��ʹ���ʹ
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    [SerializeField] private Slider healthBar; 
    private void Start()
    {
        charRenderer = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth; 
        UpdateHealthBar(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Thorn"))
        {
            TakeDamage(5f); 
            StartCoroutine(ChangeColorTemporary());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Down"))
        {
            TakeDamage(100f); 
            StartCoroutine(ChangeColorTemporary());
        }
    }

    private IEnumerator ChangeColorTemporary()
    {
        charRenderer.color = hitColor;
        yield return new WaitForSeconds(3f);
        charRenderer.color = originalColor;
    }

    private void TakeDamage(float damage)
    {
        currentHealth -= damage; 
        if (currentHealth <= 0)
        {
            currentHealth = 0; 
            Die(); 
        }
        UpdateHealthBar(); 
    }

    private void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = currentHealth / maxHealth; 
        }
    }

    private void Die()
    {
        
        charRenderer.enabled = false; 
        
        Debug.Log("Character Died");

        SceneManager.LoadScene(4);
        
    }

    
}