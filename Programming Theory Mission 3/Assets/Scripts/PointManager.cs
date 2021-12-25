using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    [SerializeField] private Cube cube;
    [SerializeField] private Sphere sphere;
    [SerializeField] private Cylindar cylindar;
    [SerializeField] private TextMeshProUGUI pointsText;
    private int points;
    
    void Start()
    {
        points = 0;
        //sphere.PointValue = -20; // will log an error that sphere can't have a negative value and instead will use the default value
        //cube.PointValue = 10; // Error because it is set to private set in cube
        sphere.PointValue = 20;
        cylindar.PointValue = -5; // is fine as it is allowed
        UpdatePointsText();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Cube>()) {
            points += cube.PointValue;
        } else if (other.GetComponent<Sphere>()) {
            points += sphere.PointValue;
        } else if (other.GetComponent<Cylindar>()) {
            points += cylindar.PointValue;
        }
        UpdatePointsText();
    }

    private void UpdatePointsText() {
        pointsText.text = "Points: " + points;
    }

    
}
