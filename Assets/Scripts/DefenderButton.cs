using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Color32 unselectedColor;

    SpriteRenderer sprite;

    
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();    
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = unselectedColor;
        }

        sprite.color = Color.white;
    }

}
