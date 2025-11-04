using System;
using System.Timers;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private GameObject _player = null;

    private void Update()
    {
        // get the position of the player
        Vector3 playerPosition = _player.transform.position;
        // theres probably a unity builtin for getting the direction
        // of the displacement vector between 2 points
        // or i can thug it out myself.
        
        transform      .      position = Vector3.MoveTowards(
            transform.position, 
            playerPosition, 
            _speed * Time.deltaTime
            );
        
        // update the position of this guy by
        // adding the calculated immediate displacement
        // to the position of my bat.
    }

    public void SetBatChasing(bool chasing)
    {
        // print("me when I enable: " + chasing);
        enabled = chasing;
    }
    
}
