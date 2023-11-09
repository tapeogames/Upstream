using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObject : MonoBehaviour
{

    public GameObject sceneObject;
    public Tile currentTile;
    public Tile leftTile;
    public Tile rightTile;
    public Tile forwardTile;
    public Tile backwardTile;

    public void SetLeftTile(Tile tile)
    {
        leftTile = tile;
    }
    public void SetRightTile(Tile tile)
    {
        rightTile = tile;
    }

    public void SetForwardTile(Tile tile)
    {
        forwardTile = tile;
    }
    public void SetBackwardTile(Tile tile)
    {
        backwardTile = tile;
    }
    public void SetCurrentTile(Tile tile)
    {
        currentTile = tile;
    }
}
