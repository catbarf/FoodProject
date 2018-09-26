using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item {

    public float uses;
    public float maxUses;

    public void OnMouseUpAsButton()
    {
        Use();
    }

    public void Use()
    {
        if (uses < maxUses)
        {
            uses++;
            Debug.Log(UseText());
        }
        else
        {
            Debug.Log(NoUsesRemainingText());
        }
    }

    public string UseText()
    {
        return "You ate a " + displayName;
    }
    
    public string NoUsesRemainingText()
    {
        return "There are no uses remaining of this item.";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
