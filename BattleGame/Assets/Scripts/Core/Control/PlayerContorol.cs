using UnityEngine;
using Core.Character.Player;


namespace Core.Control
{
    public class PlayerContorol : MonoBehaviour
    {
        private Rigidbody2D myRigidBody;

        void Start()
        {
            myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            Vector2 force = Vector2.zero;

            if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
            {
                force = new Vector2(PlayerAttribute.playerSpeed * -1, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
            {
                force = new Vector2(PlayerAttribute.playerSpeed, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
            {
                force = new Vector2(0, PlayerAttribute.playerSpeed);
            }

            if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
            {
                force = new Vector2(0, PlayerAttribute.playerSpeed * -1);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                force = new Vector2(PlayerAttribute.playerSpeed * -1, PlayerAttribute.playerSpeed);
            }

            if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                force = new Vector2(PlayerAttribute.playerSpeed, PlayerAttribute.playerSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                force = new Vector2(PlayerAttribute.playerSpeed * -1, PlayerAttribute.playerSpeed * -1);
            }

            {
                if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
                    force = new Vector2(PlayerAttribute.playerSpeed, PlayerAttribute.playerSpeed * -1);
            }

            myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);

        }
    }
}
