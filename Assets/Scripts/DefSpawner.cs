﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefSpawner : MonoBehaviour
{
    Defender defender;
    GameObject defenderParrent;
    const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        CreateDefenderParrent();
    }

    private void CreateDefenderParrent()
    {
        defenderParrent = GameObject.Find(DEFENDER_PARENT_NAME);
        if(!defenderParrent)
        {
            defenderParrent = new GameObject("Defenders");
        }
    }

    private void OnMouseDown()
    {
        AttemptToPlaceDefender(PointPositionOfDefender());
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
        if (!defender) { return; }
        Defender newDefender = Instantiate(defender, positionOfDefender, Quaternion.identity) as Defender;
        newDefender.transform.parent = defenderParrent.transform;

    }

    public void ChooseDefender(Defender defenderPrefab)
    {
        defender = defenderPrefab;
    }

    private void AttemptToPlaceDefender(Vector2 mousePositionOnGrid)
    {
        var starDisplay = FindObjectOfType<StarsDisplay>();
        int defenderCost = defender.GetDefenderCost();
        // if we have enough stars
            //spawn dewender
            //spent stars
        if (starDisplay.EnoughStars(defenderCost))
        {
            SpawnDefender(PointPositionOfDefender());
            starDisplay.SpentStars(defenderCost);
        }
    }
}
