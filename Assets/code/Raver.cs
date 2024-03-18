using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raver : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LevelManager LM;


    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;
    private Transform target;
    private int pathIndex = 0;
    private float baseSpeed;
    private GameObject temp;
    public bool greenLight = false;
    public bool redLight = false;
    
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.FindWithTag("LevelManage");
        LM = temp.GetComponent<LevelManager>();
        baseSpeed = moveSpeed;
        target = LM.path[pathIndex];
        Debug.Log(LM.path[pathIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        //check if spot is FOH and raver hasnt been checked.
        //Check if next spot is occupied
        if (pathIndex != 2){
            if (pathIndex == 3 && greenLight){
                pathIndex--;
                greenLight = false;
            }
            if (LM.pathObject[pathIndex + 1].GetComponent<Lock>().locked == false){
                //check if raver is getting close to the next position.
                if(Vector2.Distance(target.position, transform.position) <= 0.1f){
                    LM.pathObject[pathIndex].GetComponent<Lock>().locked = false;
                    pathIndex++;

                if (pathIndex == LM.path.Length){
                    //When raver reaches end, add raver to the roster to appear in club.
                    return;
                } 
                else{
                    target = LM.path[pathIndex];
                    LM.pathObject[pathIndex].GetComponent<Lock>().locked = true;
                }
            }
            }
        }
        else{
            if (greenLight == true){
                pathIndex++;
            }
            else if (redLight == true){
                target = LM.exitPoint;
            }
        }
    }
    private void FixedUpdate(){
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }

    public void updateSpeed(float newSpeed){
        moveSpeed = newSpeed;
    }

    public void resetSpeed(){
        moveSpeed = baseSpeed;
    }

    public void setLevelManager(LevelManager manager){
        LM = manager;
    }

    public void updateRedLight(bool decision){
        redLight = decision;
    }

    public void updateGreenLight(bool decision){
        greenLight = decision;
    }
}
