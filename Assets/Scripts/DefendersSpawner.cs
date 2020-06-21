using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendersSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Clicked on Game area!");

        Vector2 worldPos = GetSquareClicked();
        SpawnDefender(worldPos);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        var snapPosX = Mathf.RoundToInt(rawWorldPos.x);
        var snapPosY = Mathf.RoundToInt(rawWorldPos.y);

        Debug.Log(snapPosX + "," + snapPosY);


        return new Vector2(snapPosX, snapPosY);
    }
    private void SpawnDefender(Vector2 worldPos)
    {
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity);
    }
}
