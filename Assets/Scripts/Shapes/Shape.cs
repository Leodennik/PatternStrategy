using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class Shape : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private IHoverBehavior _hoverBehavior;

    protected void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        SetHoverBehavior(new NoHoverBehavior());
    }

    protected virtual void Start()
    {
    }

    protected void SetHoverBehavior(IHoverBehavior hoverBehavior)
    {
        _hoverBehavior = hoverBehavior;
    }

    public void Hover()
    {
        _hoverBehavior.Hover(_sprite);
    }
    
    public void UnHover()
    {
        _hoverBehavior.UnHover(_sprite);
    }
}
