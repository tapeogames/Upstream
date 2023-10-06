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
    PlayerController player;

    void Start()
    {
        player = transform.parent.parent.GetComponent<PlayerController>();//we know the parent has this script
    }


    private void OnTriggerStay(Collider other)
    {
        Tile tile = other.GetComponent<Tile>();
        if (tile != null)
        {
            switch (detectorType)
            {
                case TileDetectorType.Left:
                    player.SetLeftTile(tile);
                    break;
                case TileDetectorType.Right:
                    player.SetRightTile(tile);
                    break;
                case TileDetectorType.Forward:
                    player.SetForwardTile(tile);
                    break;
                case TileDetectorType.Backward:
                    player.SetBackwardTile(tile);
                    break;
                case TileDetectorType.Floor:
                    player.SetCurrentTile(tile);
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
                    player.SetLeftTile(null);
                    break;
                case TileDetectorType.Right:
                    player.SetRightTile(null);
                    break;
                case TileDetectorType.Forward:
                    player.SetForwardTile(null);
                    break;
                case TileDetectorType.Backward:
                    player.SetBackwardTile(null);
                    break;
                case TileDetectorType.Floor:
                    player.SetCurrentTile(null);
                    break;
            }

        }
    }

}
