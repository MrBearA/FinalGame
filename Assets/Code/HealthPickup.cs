using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthRestore = 20;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damagaeable damagaeable = collision.GetComponent<Damagaeable>();

        if(damagaeable)
        {
           bool wasHealed = damagaeable.Heal(healthRestore);

            if(wasHealed)
            {
                Destroy(gameObject);
                animator.SetTrigger(AnimationString.pickupEffect);
            }
           
        }
    }

    
}
