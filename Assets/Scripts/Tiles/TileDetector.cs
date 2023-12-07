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
        Up,
        Floor
    }

    public TileDetectorType detectorType;
    public SceneObject someObject;




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
                    someObject.SetDownTile(tile);                    
                    break;
                case TileDetectorType.Up:
                   someObject.SetUpTile(tile);                    
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
                case TileDetectorType.Up:
                    someObject.SetUpTile(null);
                    break;
                case TileDetectorType.Floor:
                    someObject.SetCurrentTile(null);
                    break;
            }

        }

    }


}
