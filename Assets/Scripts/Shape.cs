using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private string[] recognizedShapeNames = new string[3] {"Cube", "Sphere", "Capsule"};
    private string bf_ShapeName = "Shape name undefined!";
    public string shapeName
    {
        get { return bf_ShapeName; }
        set
        {
            foreach (string sN in recognizedShapeNames)
            {
                if (value == sN)
                {
                    bf_ShapeName = value;
                    return;
                }
            }
            Debug.LogError('"' + value + '"' + " is not a recognized shape name!");
        }
    }

    private string[] recognizedShapeColors = new string[3] { "Red", "Green", "Blue" };
    private string bf_ShapeColor = "Shape color undefined!";
    public string shapeColor
    {
        get { return bf_ShapeColor; }
        set
        {
            foreach (string sC in recognizedShapeColors)
            {
                if (value == sC)
                {
                    bf_ShapeColor = value;
                    return;
                }
            }
            Debug.LogError('"' + value + '"' + " is not a recognized shape color!");
        }
    }

    private GameObject shapeSpeech;
    private TextMeshProUGUI shapeSpeechText;

    [SerializeField] private Vector3 shapeSpeechOffset = Vector3.up * 2;

    private void OnMouseDown()
    {
        DisplayText(); // ABSTRACTION
    }

    public virtual void DisplayText() // ABSTRACTION
    {
        shapeSpeech = GameObject.Find("Shape Speech");
        shapeSpeechText = GameObject.Find("Shape Speech Text").GetComponent<TextMeshProUGUI>();
        shapeSpeech.transform.position = transform.position + shapeSpeechOffset;
        shapeSpeechText.text = "I am " + shapeName + ". My color is " + shapeColor + ".";
    }
}
