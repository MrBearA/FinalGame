using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryBag : MonoBehaviour, IInventory
{
    public int Gem
    {
        get => gem; set => gem = value;
    }

    public int gem = 0;
}
