using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylindar : Shape
{
    public int PointValue {get; set;} // Can be set by anyone to any value
     private void Start() {
        shapeType = "Cylindar";
        shapeColor = "Blue";
        moveSpeed = 1.5f;
    }

    protected override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("It is positioned to the Right");
    }
}
