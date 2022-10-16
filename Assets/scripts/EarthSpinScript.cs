﻿using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    public float speed = 50f;

    void Update() {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}