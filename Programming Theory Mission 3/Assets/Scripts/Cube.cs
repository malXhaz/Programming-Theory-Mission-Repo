using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public int PointValue {get; private set;} // Can only be set in the class

    private void Start() {
        shapeType = "Cube";
        shapeColor = "Red";
        moveSpeed = 1f;
        PointValue = 5;
    }

    protected override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("It is positioned to the Left");
    }

    
}
