using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public GameManagerScript GameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 1.67f;
    public float moveSpeed = 2f;
    public float startX = 0f;
    public float maxstartY = 4f;

    private void Start()
    {
        InitialPush();
        
    }

    private void InitialPush()
    {
        Vector2 dir = Random.value < 0.5? Vector2.left : Vector2.right;
        
        
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = dir * moveSpeed;
    }

    private void ResetBall()
    {
        float PosY = Random.Range(-maxstartY, maxstartY);
        Vector2 position = new Vector2(startX, PosY);
        transform.position = position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scorezone scorezone = collision.GetComponent<Scorezone>();
        if (scorezone)
        {
            GameManager.OnScoreZoneReached(scorezone.id);
            ResetBall();
            InitialPush();
        }


    }
}
