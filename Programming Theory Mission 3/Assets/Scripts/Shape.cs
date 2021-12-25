using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour // INHERITANCE - Parent
{
    protected string shapeType;
    protected string shapeColor;
    protected float moveSpeed;
    private float zRange = 3f;
    private bool isForward = true;

    private void Update() {
        Move(); // ABSTRACTION usage
        CheckMoveBoundaries();
    }

    protected virtual void DisplayText() { // POLYMORPHISM
        Debug.Log("This is a " + shapeType + " with the color: " + shapeColor);
    }

    private void OnMouseDown() {
        DisplayText(); // ABSTRACTION usage
    }

    private void Move() { // ABSTRACTION
        
        if (isForward) {
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        } else {
            transform.position += -Vector3.forward * Time.deltaTime * moveSpeed;
        }
        
    }

    private void CheckMoveBoundaries() { // ABSTRACTION
        if (transform.position.z > zRange) {
            isForward = false;
        } 
        if (transform.position.z < -zRange) {
            isForward = true;
        }
    }

    
}
