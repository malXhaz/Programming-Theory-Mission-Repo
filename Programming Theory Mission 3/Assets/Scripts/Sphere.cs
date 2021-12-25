using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE - Child
{
    private int pointValue =10; // can be set by anyone but only positive values // ENCAPSULATION
    public int PointValue { // ENCAPSULATION with full get and set 
        get {
            return pointValue;}
        set {
            if (value >= 1) {
                pointValue = value;
            } else {
                Debug.LogError("Sphere must have a positive point value");
            }
        }
    }

    private void Start() {
        shapeType = "Sphere";
        shapeColor = "Green";
        moveSpeed = 0.5f;
    }

    protected override void DisplayText() // POLYMORPHISM
    {
        base.DisplayText();
        Debug.Log("It is positioned in the Middle");
    }
}
