using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMov : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Vector2 rawInput;

    void Update()
    {
        Move();
    }

    void Move()
    {
        //vector3를 받는 delta를 만들어 rawInput, moveSpeed, Time.deltaTime을 곱하여 캐릭터 movement제작
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }

    void OnMove(InputValue value)
    {
        //inputvalue에서 value값을 가져와서 rawInput에 대입시킨 후 디버그 로그로 rawInput값 확인
        rawInput = value.Get<Vector2>();
        Debug.Log(rawInput);
    }
}
