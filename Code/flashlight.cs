using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {
    public KeyCode key = KeyCode.F;
    private Light lit;

    // START:
    void Start() {
        lit = GetComponent<Light>();
    }

    // UPDATE:
    void Update() {
        if (Input.GetKeyUp(key)) {
            lit.enabled = !lit.enabled;
        }
    }
}