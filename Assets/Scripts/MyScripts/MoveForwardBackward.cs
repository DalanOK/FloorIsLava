using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBackward : MonoBehaviour
{
    public float speed = 5f; // �������� �������� �������
    public float distance = 10f; // ����������, �� ������� ������ ����� ������������ ����� � �����
    private Vector3 initialPosition;
    public Vector3 direction = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ���������� Mathf.PingPong ��� �������� ���������� �������� ����� ��������� � �������� ��������
        float pingPongValue = Mathf.PingPong(Time.time * speed / distance, 1f);
        transform.position = initialPosition + direction * distance * pingPongValue;
    }
}
