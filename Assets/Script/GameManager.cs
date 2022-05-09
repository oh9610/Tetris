using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool isEmpty_block = false;

    Block create_block;

    public GameObject[] b = new GameObject[7];

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty_block == false)
        {
            create_block = gameObject.AddComponent<Block>();
            create_block.block = b[1];
            create_block.b_c = true;
            create_block.block.transform.position = new Vector2(0, 0);
            Instantiate(create_block.block);
            isEmpty_block = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isEmpty_block = false;
        }

    }






}
