using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private int pointValue =10; // can be set by anyone but only positive values
    public int PointValue {
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

    protected override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("It is positioned in the Middle");
    }
}
