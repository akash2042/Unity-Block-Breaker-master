using UnityEngine;

public class Paddle : MonoBehaviour
{
     private float mousePosInBlocksUnits;
    private float force = 7000;
    private Vector3 paddlePos;
    private Rigidbody2D paddleRB;

      [SerializeField] private float minPos = 1.84f;
      [SerializeField] private float maxPos = 14.14f;
      [SerializeField] private float screenWidthInBlocksUnits = 16f; 

    void Awake()
    {
        paddleRB = GetComponent<Rigidbody2D>();
        // Cursor.visible = false;
        paddlePos = new Vector3(transform.localPosition.x, transform.localPosition.y, 0f);
    }

    void Update()
    {
        Play();
    }

    private void Play()
    {

        /* if (Input.GetMouseButtonDown(0)) {

             if (Input.mousePosition.x < Screen.width / 2)
                 paddleRB.AddForce(Vector2.left * force * Time.deltaTime);


             if (Input.mousePosition.x > Screen.width / 2)
                 paddleRB.AddForce(Vector2.right * force * Time.deltaTime);
          */

        mousePosInBlocksUnits = ((Input.mousePosition.x / Screen.width) * screenWidthInBlocksUnits);
        paddlePos.x = Mathf.Clamp(mousePosInBlocksUnits, minPos, maxPos);
        transform.localPosition = paddlePos;


        }
    }


