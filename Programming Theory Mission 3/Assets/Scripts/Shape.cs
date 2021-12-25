using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeType;
    protected string shapeColor;
    protected float moveSpeed;
    private float zRange = 3f;
    private bool isForward = true;

    private void Update() {
        Move();
        CheckMoveBoundaries();
    }

    protected virtual void DisplayText() {
        Debug.Log("This is a " + shapeType + " with the color: " + shapeColor);
    }

    private void OnMouseDown() {
        DisplayText();
    }

    private void Move() {
        
        if (isForward) {
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        } else {
            transform.position += -Vector3.forward * Time.deltaTime * moveSpeed;
        }
        
    }

    private void CheckMoveBoundaries() {
        if (transform.position.z > zRange) {
            isForward = false;
        } 
        if (transform.position.z < -zRange) {
            isForward = true;
        }
    }

    
}
