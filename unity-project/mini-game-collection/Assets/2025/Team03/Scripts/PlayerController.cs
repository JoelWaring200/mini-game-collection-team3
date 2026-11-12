using UnityEngine;

namespace MiniGameCollection.Games2026.Team03
{
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

            // -1 to 1
            float axisX = ArcadeInput.Players[(int)PlayerID].AxisX;
            float axisY = ArcadeInput.Players[(int)PlayerID].AxisY;

            float movementX = axisX * Time.deltaTime * PlayerSpeed;
            float movementY = axisY * Time.deltaTime * PlayerSpeed;
            Vector3 newPosition = transform.position + new Vector3(movementX, movementY, 0);
            Rigidbody2D.MovePosition(newPosition);
        }
    }
}