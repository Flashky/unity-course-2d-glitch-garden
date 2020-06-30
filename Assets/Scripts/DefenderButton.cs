using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Color32 unselectedColor;
    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = unselectedColor;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefendersSpawner>().SetSelectedDefender(defenderPrefab);
    }

}
