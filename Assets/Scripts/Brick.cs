using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private Sprite[] hitsprite = null;

    private int numberOfHits = 0;

    public void OnCollision()
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        numberOfHits++;

        int maxHits = hitsprite.Length + 1;

        if (numberOfHits >= maxHits)
        {
            gameObject.SetActive(false);

        }
    } 
}