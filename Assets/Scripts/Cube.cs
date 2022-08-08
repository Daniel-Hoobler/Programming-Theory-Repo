using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    public string myName { get; private set; } = "Cube"; // ENCAPSULATION

    public string myColor { get; private set; } = "Red"; // ENCAPSULATION

    public override void DisplayText() // POLYMORPHISM
    {
        shapeName = myName;
        shapeColor = myColor;

        base.DisplayText();
    }
}
