using UnityEngine;

public class SimpleColorHoverBehavior : IHoverBehavior
{
    private Color _previousColor;
    private Color _hoverColor;

    public SimpleColorHoverBehavior(Color hoverColor)
    {
        _hoverColor = hoverColor;
    }
    
    public void Hover(SpriteRenderer sprite)
    {
        if (_previousColor != _hoverColor)
        {
            _previousColor = sprite.color;
            sprite.color = _hoverColor;
        }
    }

    public void UnHover(SpriteRenderer sprite)
    {
        sprite.color = _previousColor;
    }
}