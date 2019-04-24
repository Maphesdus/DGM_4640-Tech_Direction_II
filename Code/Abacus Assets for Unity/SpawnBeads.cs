using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeads : MonoBehaviour {
    public GameObject rod;
    //public Transform bead;
    public int Rods = 13;
    //public int BeadsPerRod = 7;
    public float offset = 7.0f;

    // START:
    void Start() {
        for (int x = 0; x < Rods; x++) {
            Instantiate(rod, new Vector3((x - offset) * 1.2f, this.transform.position.y, this.transform.position.z), this.transform.rotation);
        }

        /*for (int x = 0; x < Rods; x++) {
            Instantiate(rod, new Vector3(x, 0, 0), this.transform.rotation);
            for (int z = 0; z < BeadsPerRod; z++) {
                Instantiate(bead, new Vector3(x, 0, z), this.transform.rotation);
            }
        }*/
    } // END Start

    // UPDATE:
    void Update() {
        
    } // END Update

} // public class SpawnBeads