using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender(PointPositionOfDefender());
    }

    private static Vector2 PointPositionOfDefender()
    {
        Vector2 mousePositionGlobal = Input.mousePosition;
        Vector2 mousePositionInTheGame = Camera.main.ScreenToWorldPoint(mousePositionGlobal);
        return mousePositionInTheGame;
    }

    private void SpawnDefender(Vector2 positionOfDefender)
    {
        GameObject newDefender = Instantiate(defender, positionOfDefender, Quaternion.identity) as GameObject;
    }
}
