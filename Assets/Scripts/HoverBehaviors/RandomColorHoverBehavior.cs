using UnityEngine;

public class RandomColorHoverBehavior : IHoverBehavior
{
    private Color _previousColor;

    public void Hover(SpriteRenderer sprite)
    {
        _previousColor = sprite.color;
        sprite.color = new Color(Random.value, Random.value, Random.value);
    }

    public void UnHover(SpriteRenderer sprite)
    {
        sprite.color = _previousColor;
    }
}