using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
    [SerializeField]
    private CreateOrJoinRoomCanvase _createOrJoinRoomCanvase;

    public CreateOrJoinRoomCanvase CreateOrJoinRoomCanvase { get { return _createOrJoinRoomCanvase; } }

    [SerializeField]
    private CurrentRoomCanvas _currentRoomCanvas;

    public CurrentRoomCanvas CurrentRoomCanvas { get { return _currentRoomCanvas; } }

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CreateOrJoinRoomCanvase.FirstInitialize(this);
        CurrentRoomCanvas.FirstInitialize(this);
    }
}
