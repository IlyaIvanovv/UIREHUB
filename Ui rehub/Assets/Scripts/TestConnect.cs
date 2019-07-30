using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        Debug.Log("Connecting to server.", this);
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.ConnectUsingSettings();
    }
    public override  void OnConnectedToMaster()
    {
        Debug.Log("Connected to server", this);
        Debug.Log(PhotonNetwork.LocalPlayer.NickName, this);
        if (!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from server from reason" + cause.ToString(), this);
    }

    public override void OnJoinedLobby()
    {
        print("Joined Lobby");
    }

}
