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
            //시리얼 넘버가 기록되는 함수 다음 함수로 넘어간당
            // 오토 씽크 씬을 트루로 설정한다.

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
        //룸이 생성될 때 룸의 셋팅들을 넣어줄 수 있는 함수
        print("OnCreateRoom");
    }

    public override void OnJoinedRoom()
    {
        //룸이 조인될 때 셋팅들을 넣어줄 수 있는 함수.
        print("OnJoinedRoom()");
        // PhotonNetwork.LoadLevel("GameScenes01");
        // leftRoom의 경우 완전히 방이 떠났을 때 사용된다.

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
