using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public int gemValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            IInventory inventory = other.GetComponent<IInventory>();

            if(inventory != null )
            {
                inventory.Gem = inventory.Gem + gemValue;
                Debug.Log("gem is " + inventory.Gem);
                gameObject.SetActive(false);
            }
        }
    }
}
