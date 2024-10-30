using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int currentTilePosition = new Vector2Int(0, 0);
    [SerializeField] Vector2Int playerTilePosition;
    Vector2Int onTileGridPlayerPosition;
    [SerializeField] float tileSize = 20f;
    GameObject[,] terrainTiles;

    [SerializeField] int terrainTileHorizontalCount;
    [SerializeField] int terrainTileVerticalCount;

    [SerializeField] int fieldOfVisionHeight = 3;
    [SerializeField] int fieldOfVisionWidth = 3;


    private void Awake()
    {
        terrainTiles = new GameObject[terrainTileHorizontalCount, terrainTileVerticalCount];
    }

    private void Update()
    {
        playerTilePosition.x = (int)(playerTransform.position.x / tileSize);
        playerTilePosition.y = (int)(playerTransform.position.y / tileSize);
        if (currentTilePosition != playerTilePosition)
        {
            currentTilePosition = playerTilePosition;

            UpdateOnTileGridPlayerPosition();
            UpdateTileOnScreen();

        }
    }

    private void UpdateTileOnScreen()
    {
        for(int pov_x = 0; pov_x < fieldOfVisionWidth; pov_x++){
            
        }
    }

    private void UpdateOnTileGridPlayerPosition()
    {
        if (onTileGridPlayerPosition.x >= 0)
        {
            onTileGridPlayerPosition.x = playerTilePosition.x % terrainTileHorizontalCount;

        }
        else
        {
            onTileGridPlayerPosition.x = terrainTileHorizontalCount -1 
            + playerTilePosition.x % terrainTileHorizontalCount;
        }

        if (onTileGridPlayerPosition.y >= 0)
        {
            onTileGridPlayerPosition.y = playerTilePosition.y % terrainTileVerticalCount;
        }else{
            onTileGridPlayerPosition.y =terrainTileVerticalCount -1 
            + playerTilePosition.y % terrainTileVerticalCount;
        }


    }

    public void Add(GameObject tileGameObject, Vector2Int tilePosition)
    {
        terrainTiles[tilePosition.x, tilePosition.y] = tileGameObject;
    }
}
