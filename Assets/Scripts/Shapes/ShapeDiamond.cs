using UnityEngine;

public class ShapeDiamond : Shape
{
    protected override void Start()
    {
        base.Start();
        SetHoverBehavior(new RandomColorHoverBehavior());
    }
}
