using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObject : MonoBehaviour
{

    public GameObject sceneObject;
    public Tile currentTile;
    public Tile leftTile;
    public Tile rightTile;
    public Tile downTile;
    public Tile upTile;

    public void SetLeftTile(Tile tile)
    {
        leftTile = tile;
    }
    public void SetRightTile(Tile tile)
    {
        rightTile = tile;
    }

    public void SetDownTile(Tile tile)
    {
        downTile = tile;
    }
    public void SetUpTile(Tile tile)
    {
        upTile = tile;
    }
    public void SetCurrentTile(Tile tile)
    {
        currentTile = tile;
    }
}
