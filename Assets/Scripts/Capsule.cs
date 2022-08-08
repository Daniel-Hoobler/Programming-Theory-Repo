using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape // INHERITANCE
{
    public string myName { get; private set; } = "Capsule"; // ENCAPSULATION

    public string myColor { get; private set; } = "Blue"; // ENCAPSULATION

    public override void DisplayText() // POLYMORPHISM
    {
        shapeName = myName;
        shapeColor = myColor;

        base.DisplayText();
    }
}
