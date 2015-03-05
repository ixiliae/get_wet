using UnityEngine;

namespace CompleteProject
{
    public class EnemyHealth : MonoBehaviour
    {
        public int startingHealth = 100;            // The amount of health the enemy starts the game with.
        public int currentHealth;                   // The current health the enemy has.
        public float sinkSpeed = 2.5f;              // The speed at which the enemy sinks through the floor when dead.

        BoxCollider capsuleCollider;            // Reference to the capsule collider.
        bool isDead;                                // Whether the enemy is dead.
        bool isSinking;                             // Whether the enemy has started sinking through the floor.


        void Awake ()
        {
            // Setting up the references.
            capsuleCollider = GetComponent <BoxCollider> ();

            // Setting the current health when the enemy first spawns.
            currentHealth = startingHealth;
        }


        void Update ()
        {
            // If the enemy should be sinking...
        }

		void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.name == "Bulletv2(clone)")
            {
                TakeDamage(20);
                Destroy(col.gameObject);
            }
			TakeDamage(20);
			Destroy(col.gameObject);
        }

        public void TakeDamage (int amount)
        {
            // If the enemy is dead...
            if (isDead)
             // ... no need to take damage so exit the function.
				return;

            // Play the hurt sound effect.

            // Reduce the current health by the amount of damage sustained.
            currentHealth -= amount;
            
            // Set the position of the particle system to where the hit was sustained.

            // If the current health is less than or equal to zero...
            if(currentHealth <= 0)
            {
                // ... the enemy is dead.
                Death ();
            }
        }


        void Death ()
        {
            // The enemy is dead.
            isDead = true;
			StartSinking ();
			
        }


        public void StartSinking ()
        {
        // The enemy should no sink.
            isSinking = true;

            // After 2 seconds destory the enemy.
            Destroy (gameObject, 0f);
        }
    }
}