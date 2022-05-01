using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public Vector2 position;
    public int movementIncrement;

    public PlayerMovement(Vector2 startingPos, int movementIncrement)
    {
        this.position = startingPos;
        this.movementIncrement = movementIncrement;
    }

    // Command Pattern
    public void MoveUp(float Input, Transform transform)
    {
        transform.Translate(Vector3.up * Input * movementIncrement);
    }

    public void MoveDown(float Input, Transform transform)
    {
        transform.Translate(Vector3.up * Input * movementIncrement);
    }

    public void MoveLeft(float Input, Transform transform)
    {
        transform.Translate(Vector3.right * Input * movementIncrement);
    }

    public void MoveRight(float Input, Transform transform)
    {
        transform.Translate(Vector3.right * Input * movementIncrement);
    }
}
