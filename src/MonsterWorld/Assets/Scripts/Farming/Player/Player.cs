using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMovement playerMovement;
    public PlayerInventory playerInventory;

    public static Player Instance;

    public bool canBuyTomatoad;
    public bool canBuyGiraffodil;
    public bool canBuyPumpkitty;

    public int movementIncrement;
    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = new PlayerMovement(transform.position, movementIncrement);
        canBuyTomatoad = false;
        canBuyGiraffodil = false;
        canBuyPumpkitty = false;
    }

    private void Awake()
    {
        playerInventory = new PlayerInventory();
        canMove = true;
        Instance = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            CheckInput();
        }
    }

    void CheckInput()
    {
        float xInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * Time.deltaTime;
        //Debug.Log(xInput);

        if (xInput > 0)
        {
            //Debug.Log("move right");
            playerMovement.MoveRight(xInput, this.transform);
        }

        if (xInput < 0)
        {
            playerMovement.MoveLeft(xInput, this.transform);
        }

        if (yInput > 0)
        {
            playerMovement.MoveUp(yInput, this.transform);
        }

        if (yInput < 0)
        {
            playerMovement.MoveDown(yInput, this.transform);
        }
    }

    
}
