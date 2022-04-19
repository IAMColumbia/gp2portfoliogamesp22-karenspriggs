using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMovement playerMovement;
    public PlayerInventory playerInventory;

    public static Player Instance;

    public int movementIncrement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = new PlayerMovement(transform.position, movementIncrement);
        playerInventory = new PlayerInventory();
    }

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        float xInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * Time.deltaTime;
        //Debug.Log(xInput);

        if (xInput > 0)
        {
            //Debug.Log("move right");
            playerMovement.MoveRight(xInput);
        }

        if (xInput < 0)
        {
            playerMovement.MoveLeft(xInput);
        }

        if (yInput > 0)
        {
            playerMovement.MoveUp(yInput);
        }

        if (yInput < 0)
        {
            playerMovement.MoveDown(yInput);
        }

        //Debug.Log(playerMovement.position);
        this.transform.position = playerMovement.position;
    }
}