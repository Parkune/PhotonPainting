using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : Photon.PunBehaviour
{

    void Start()
    {
        PhotonNetwork.automaticallySyncScene = true;
    }

    public void MyPhotonConnect()
    {
            //�ø��� �ѹ��� ��ϵǴ� �Լ� ���� �Լ��� �Ѿ��
            // ���� ��ũ ���� Ʈ��� �����Ѵ�.

            if (PhotonNetwork.connected)
            {
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                PhotonNetwork.ConnectUsingSettings("1");
            }

            print("MyConnectPhoton()");

            //isConnecting = true;

    }


    public override void OnConnectedToMaster()
    {
        /* if(isConnecting)
         { 
         PhotonNetwork.JoinRandomRoom();
         }
         else
         {
             PhotonNetwork.Disconnect();

         }
 */
        PhotonNetwork.JoinRandomRoom();

        print("OnConnectedToMaster()");
    }


    public override void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        print("OnPhotonJoinRoomFailed()");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { maxPlayers = 4 }, null);
    }


    public override void OnPhotonRandomJoinFailed(object[] codeAndMsg)
    {
        print("OnPhotonRandomJoinFailed()");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { maxPlayers = 4 }, null);
    }

    public override void OnCreatedRoom()
    {
        //���� ������ �� ���� ���õ��� �־��� �� �ִ� �Լ�
        print("OnCreateRoom");
    }

    public override void OnJoinedRoom()
    {
        //���� ���ε� �� ���õ��� �־��� �� �ִ� �Լ�.
        print("OnJoinedRoom()");
        // PhotonNetwork.LoadLevel("GameScenes01");
        // leftRoom�� ��� ������ ���� ������ �� ���ȴ�.

        /*      if (PhotonNetwork.connected)
              {
                  PhotonNetwork.Disconnect();
              }
              else
              {


              }*/
        PhotonNetwork.LoadLevel("GameScene01");

    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
