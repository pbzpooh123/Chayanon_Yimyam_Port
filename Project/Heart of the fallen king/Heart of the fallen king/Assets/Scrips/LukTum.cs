using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LukTum : MonoBehaviour
{
    public float speed = 2.0f;  // ความเร็วในการแกว่ง
    public float maxAngle = 45.0f;  // มุมสูงสุดที่ลูกตุ้มจะแกว่งไปถึง

    private void Update()
    {
        // ใช้ Mathf.Sin เพื่อคำนวณการแกว่งของลูกตุ้ม
        float angle = maxAngle * Mathf.Sin(Time.time * speed);

        // ตั้งค่าการหมุน (rotation) ของลูกตุ้มตามมุมที่คำนวณได้
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

}
