using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    // Base script for all stats (player, enemy, npc) //

    public int maxHealth = 100;
    public int currentHealth { get; private set; } // value available to other classes. BUT can only set value from here

    public Stat damage;
    public Stat armour;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage (int damage)
    {
        damage -= armour.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue); // damage cannot go below 0 and into negatives

        currentHealth -= damage;
        Debug.Log(transform.name + " takes damage ");

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public virtual void Death ()
    {
        Debug.Log("Death, Death, DEATH!");
    }
}
