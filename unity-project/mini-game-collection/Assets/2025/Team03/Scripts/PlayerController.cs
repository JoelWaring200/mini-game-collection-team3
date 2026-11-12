using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MiniGameBehaviour
{
    [field: SerializeField] public PlayerID PlayerID { get; private set; }
    [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }
    [field: SerializeField] public float PlayerSpeed { get; private set; } = 10f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = ArcadeInput.Players[(int)PlayerID];
        Vector3 newPosition = Transform.position + velocity;
    }
}
