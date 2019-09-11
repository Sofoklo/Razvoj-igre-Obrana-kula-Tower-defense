using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {


    public float startSpeed = 10f;

    public float speed;

    public float startHealth = 100;
    private float health;

    public int MoneyGain = 5;

    public GameObject deathEffect;

    public Image healthBar;

    void Start ()
    {
        speed = startSpeed;
        health = startHealth;
    }




    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += MoneyGain;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }

}
