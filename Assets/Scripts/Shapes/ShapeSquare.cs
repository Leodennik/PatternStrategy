using UnityEngine;

public class ShapeSquare : Shape
{
    protected override void Start()
    {
        base.Start();
        SetHoverBehavior(new SimpleColorHoverBehavior(Color.blue));
    }
}
