using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMagnet : MonoBehaviour
{
    public float CoinSpeed;
    public Transform Player;
    private bool ReadyToMove;

    void Update()
    {
        if(ReadyToMove){
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, CoinSpeed * Time.deltaTime); //if player in radius of coin, move coin towards player
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            GetComponent<HoverUpAndDown>().enabled = false;
            ReadyToMove = true;
            Player = other.transform;
        }
    }
}
