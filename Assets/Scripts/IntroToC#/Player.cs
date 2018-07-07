using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player  {

    private float health = 100f;
    private string name = "Wizard";

    public Player() {

    }

    public Player(string name, float health) {

        this.name = name;
        this.health = health;
    }

    public void SetHealth(float health, string name) {

        this.health = health;

    }

    public float GetHealth() {

        return this.health;
    }

    public void PlayerInfo() {

        Debug.Log("Player name is: " + name + "And Players Health Is: " + health);
    }
}	// Main Class
