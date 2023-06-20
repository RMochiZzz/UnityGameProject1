using UnityEngine;
using Core.Character.Player;


namespace Core.Control
{
    public class PlayerContorol : MonoBehaviour
    {
        private Rigidbody2D myRigidBody;
        private PlayerAttribute playerAttribute;

        void Start()
        {
            myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
            playerAttribute = GetComponent<PlayerAttribute>();
        }

        void FixedUpdate()
        {
            Vector2 force = Vector2.zero;

            if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
            {
                force = new Vector2(playerAttribute.PlayerSpeed * -1, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
            {
                force = new Vector2(playerAttribute.PlayerSpeed, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
            {
                force = new Vector2(0, playerAttribute.PlayerSpeed);
            }

            if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
            {
                force = new Vector2(0, playerAttribute.PlayerSpeed * -1);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                force = new Vector2(playerAttribute.PlayerSpeed * -1, playerAttribute.PlayerSpeed);
            }

            if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                force = new Vector2(playerAttribute.PlayerSpeed, playerAttribute.PlayerSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                force = new Vector2(playerAttribute.PlayerSpeed * -1, playerAttribute.PlayerSpeed * -1);
            }

            {
                if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
                    force = new Vector2(playerAttribute.PlayerSpeed, playerAttribute.PlayerSpeed * -1);
            }

            myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);

        }
    }
}
