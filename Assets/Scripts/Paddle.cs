using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float id;
    public float moveSpeed = 2f;

    private void Update()
    {
        float value = ProccesInput();
        Move();
    }

    private float ProcessInput()
    {


        return 0f;
    }

    private void Move(float value)
    {


    }
}
