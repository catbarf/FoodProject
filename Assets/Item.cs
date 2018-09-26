using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public string displayName;
    public float weight;
    public float cost;

    public float GetPricePerWeight()
    {
        return cost / weight;
    }

    public override string ToString()
    {
        return "Item Name: " + displayName + "\ncost " + cost.ToString() + "\nWeight: " + weight.ToString() + "\nCost Perk Kilo " + GetPricePerWeight().ToString();
    }

    public void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
}
