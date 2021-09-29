using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class SyncLine : Photon.PunBehaviour, IPunObservable
    {

    private LineRenderer line;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {

            stream.SendNext(º¤ÅÍ3¹è¿­);
        }
        else
        {
            Vector3[] pos = (Vector3[])stream.ReceiveNext();

            foreach()
            {
                
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
