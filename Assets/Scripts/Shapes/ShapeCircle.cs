public class ShapeCircle : Shape
{
    protected override void Start()
    {
        base.Start();
        SetHoverBehavior(new NoHoverBehavior());
    }
}
