using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileDetectorObject : MonoBehaviour
{
    public enum TileDetectorType
    {
        Left,
        Right,
        Forward,
        Backward,
        Floor
    }

    public TileDetectorType detectorType;
    public SceneObject someObject;

    public static bool isInside = false;

    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Tile tile = other.GetComponent<Tile>();
        if (tile != null)
        {
                switch (detectorType)
                {
                
                    case TileDetectorType.Left:
                        if (tile is not Stalagmite && tile is not Sand || (tile is Sand && isInside))
                        {
                            someObject.SetLeftTile(tile);
                        }
                        break;
                    case TileDetectorType.Right:
                        if (tile is not Stalagmite && tile is not Sand || (tile is Sand && isInside))
                        {
                            someObject.SetRightTile(tile);
                        }
                        break;
                    case TileDetectorType.Forward:
                        if (tile is not Stalagmite && tile is not Sand || (tile is Sand && isInside))
                        {
                            someObject.SetDownTile(tile);
                        }
                        break;
                    case TileDetectorType.Backward:
                        if (tile is not Stalagmite && tile is not Sand || (tile is Sand && isInside))
                        {
                            someObject.SetUpTile(tile);
                        }
                        break;
                    case TileDetectorType.Floor:
                        someObject.SetCurrentTile(tile);
                        break;
                }
        }
    }
    private void OnTriggerExit(Collider other)
    {

        Tile tile = other.GetComponent<Tile>();
        if (tile != null)
        {
            switch (detectorType)
            {
                case TileDetectorType.Left:
                    someObject.SetLeftTile(null);
                    break;
                case TileDetectorType.Right:
                    someObject.SetRightTile(null);
                    break;
                case TileDetectorType.Forward:
                    someObject.SetDownTile(null);
                    break;
                case TileDetectorType.Backward:
                    someObject.SetUpTile(null);
                    break;
                case TileDetectorType.Floor:
                    someObject.SetCurrentTile(null);
                    break;
            }

        }

    }




}
