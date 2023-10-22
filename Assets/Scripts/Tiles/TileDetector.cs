using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetector : MonoBehaviour
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
                    someObject.SetLeftTile(tile);
                    break;
                case TileDetectorType.Right:
                    someObject.SetRightTile(tile);
                    break;
                case TileDetectorType.Forward:
                    someObject.SetForwardTile(tile);
                    break;
                case TileDetectorType.Backward:
                    someObject.SetBackwardTile(tile);
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
                    someObject.SetForwardTile(null);
                    break;
                case TileDetectorType.Backward:
                    someObject.SetBackwardTile(null);
                    break;
                case TileDetectorType.Floor:
                    someObject.SetCurrentTile(null);
                    break;
            }

        }

    }


}
