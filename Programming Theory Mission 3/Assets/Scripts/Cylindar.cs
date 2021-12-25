using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylindar : Shape // INHERITANCE - Child
{
    public int PointValue {get; set;} // Can be set by anyone to any value // ENCAPSULATION
     private void Start() {
        shapeType = "Cylindar";
        shapeColor = "Blue";
        moveSpeed = 1.5f;
    }

    protected override void DisplayText() // POLYMORPHISM
    {
        base.DisplayText();
        Debug.Log("It is positioned to the Right");
    }
}
