using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    public string myName { get; private set; } = "Sphere"; // ENCAPSULATION

    public string myColor { get; private set; } = "Green"; // ENCAPSULATION

    public override void DisplayText() // POLYMORPHISM
    {
        shapeName = myName;
        shapeColor = myColor;

        base.DisplayText();
    }
}
