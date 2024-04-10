using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMap5_1 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 6;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(direction, 0f, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Sửa điều kiện kiểm tra giới hạn di chuyển trái và phải
        if (transform.position.x > 8f || transform.position.x < 1.3f)
        {
            direction *= -1;
        }
    }

    public int scoreValue = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Tăng điểm số khi viên đạn va chạm vào mục tiêu
            ScoreController.Instance.IncreaseScore(scoreValue);

            // Biến mục tiêu và viên đạn biến mất
            Destroy(gameObject); // Mục tiêu
            Destroy(collision.gameObject); // Viên đạn
        }
    }
}