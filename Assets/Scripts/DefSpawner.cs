using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefSpawner : MonoBehaviour
{
    [SerializeField] Defender defender;

    private void OnMouseDown()
    {
        SpawnDefender(PointPositionOfDefender());
        Debug.Log(PointPositionOfDefender());
    }

    private static Vector2 PointPositionOfDefender()
    {
        Vector2 mousePositionGlobal = Input.mousePosition;
        Vector2 mousePositionInTheGame = Camera.main.ScreenToWorldPoint(mousePositionGlobal);
        Vector2 mousePositionOnTheGrid = SnapToGrid(mousePositionInTheGame);
        return mousePositionOnTheGrid;
    }

    private static Vector2 SnapToGrid(Vector2 rawMousePositionInTheGame)
    {
        float newX = Mathf.RoundToInt(rawMousePositionInTheGame.x);
        float newY = Mathf.RoundToInt(rawMousePositionInTheGame.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 positionOfDefender)
    {
        Defender newDefender = Instantiate(defender, positionOfDefender, Quaternion.identity) as Defender;
    }

    public void ChooseDefender(Defender defenderPrefab)
    {
        defender = defenderPrefab;
    }
}
