using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    // Base script for all stats //

    public int maxHealth = 400;
    public int currentHealth { get; private set; } // value available to other classes. BUT can only set value from here

    public Stat damage;
    

    public event System.Action<int, int> OnHealthChange;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Test
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        
        damage = Mathf.Clamp(damage, 0, int.MaxValue); // damage cannot go below 0 and into negatives

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (OnHealthChange != null)
        {
            OnHealthChange(maxHealth, currentHealth);
        }

        if (currentHealth <= 0)
        {
            Death();
            //FindObjectOfType<GameManager>().(); // To End Game
        }
    }

    public virtual void Death()
    {
        Debug.Log("death, Death, DEATH!");
        PlayerManager.instance.KillPlayer();
    }

}
    
