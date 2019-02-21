﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour {
    [SerializeField] private int CircleCount;
    private static int _tempCounter;

    private void Start() {
        _tempCounter = CircleCount;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Heart") {
            _tempCounter--;

            if (_tempCounter == 0)
                print("level completed");
        }
    }


    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Heart")
             _tempCounter = CircleCount;
    }

}
