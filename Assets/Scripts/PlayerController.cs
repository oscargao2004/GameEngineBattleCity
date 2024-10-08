using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerController : MonoBehaviour
{
    private Vector3 _pos;
    private Vector3 _rot;
    [SerializeField] private float moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        _pos += new Vector3(playerInput.x, playerInput.y, 0).normalized * moveSpeed * Time.deltaTime;

        if (playerInput.y > 0f)
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        if (playerInput.y < 0f)
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        if (playerInput.x > 0f)
            transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        if (playerInput.x < 0f)
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            
        transform.position = _pos;
    }
    
    
    
}
