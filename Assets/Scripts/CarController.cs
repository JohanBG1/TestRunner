using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private int wins = 0;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 1 * moveSpeed * Time.deltaTime, 0);
        }

        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 1 * moveSpeed * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FinshLine")
        {
            wins++;
        }
    }
}
