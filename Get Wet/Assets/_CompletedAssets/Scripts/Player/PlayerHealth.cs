using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI's health bar.                                           
    public bool isDead;
    NetworkView net;
 
    bool damaged;                                               // True when the player gets damaged.

    void Start()
    {
        isDead = false;
        net = GetComponent<NetworkView>();
    }
    void Awake()
    {
        //playerAudio = GetComponent<AudioSource>();

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    void Update()
    {
        if (isDead)
            Death();
        // Reset the damaged flag.
        damaged = false;
      
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Bulletv2(Clone)")
        {
			
            Destroy(col.gameObject);
        }
    }
    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;
        PlayerManager.Instance.AddHealth(0, -amount);

        // Set the health bar's value to the current health.
        //healthSlider.value = currentHealth;

        // Play the hurt sound effect.
       // playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0)
        {
            // ... it should die.
            Death();
        }
    }


    public void Death()
    {
        // Set the death flag so this function won't be called again.
        

        // Turn off any remaining shooting effects.

        isDead = true;
        // Tell the animator that the player is dead.
        transform.gameObject.GetComponent<Animation>().Play("tPose");
        PlayerManager.Instance.AddDeaths(0, 1);


        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
    }
}