using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Camera _camera;
    private int _layerShape;

    private Shape _previousHoverShape;
    private Shape _hoverShape;
    private void Awake()
    {
        _camera = Camera.main;
        _layerShape = LayerMask.GetMask("Shape");
    }

    private void Update()
    {
        _hoverShape = GetShape(_camera.ScreenToWorldPoint(Input.mousePosition));

        if (_hoverShape != null)
        {
            if (_hoverShape != _previousHoverShape)
            {
                if (_previousHoverShape != null) _previousHoverShape.UnHover();
                _hoverShape.Hover();
                _previousHoverShape = _hoverShape;
            }
        }
        else
        {
            if (_previousHoverShape != null)
            {
                _previousHoverShape.UnHover();
                _previousHoverShape = null;
            }
        }
    }

    private Shape GetShape(Vector2 position)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero, 10, _layerShape);
        if (hit.collider != null)
        {
            Shape shape = hit.collider.GetComponent<Shape>();
            if (shape == null)
            {
                throw new Exception(hit.collider.name + " doesn't have 'Shape' component!");
            }

            return shape;
        }

        return null;
    }
}