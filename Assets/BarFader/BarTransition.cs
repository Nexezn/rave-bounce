using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarTransition : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject topBar;
    [SerializeField] private GameObject middleBar;
    [SerializeField] private GameObject bottomBar;
    [Header("Attributes")]
    [SerializeField] private float totalTime = 1;
    private Vector3 topBarTarget = new Vector3(0, -100, 0);
    private Vector3 topBarReset = new Vector3(0, 100, 0);
    private Vector3 middleBarTarget = new Vector3(0, 0, 0);
    private Vector3 middleBarReset = new Vector3(-100, 0, 0);
    private Vector3 bottomBarTarget = new Vector3(0, 100, 0);
    private Vector3 bottomBarReset = new Vector3(0, -100, 0);
    private Vector3 topStart;
    private Vector3 middleStart;
    private Vector3 bottomStart;
    // Start is called before the first frame update
    void Start()
    {
        topStart = topBar.GetComponent<RectTransform>().anchoredPosition;
        bottomStart = bottomBar.GetComponent<RectTransform>().anchoredPosition;
        middleStart = middleBar.GetComponent<RectTransform>().position;
    }

    public void BarTransitionOn(string newScene = ""){
        StartCoroutine(BarTransitionRoutine());
        IEnumerator BarTransitionRoutine(){
            Vector3 topPos = topBar.transform.position;
            float timer = 0;
            while(timer < totalTime){
                yield return null;
                timer += Time.deltaTime;
                float total = timer / totalTime;
                topBar.GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(topStart, topBarTarget, total);
                bottomBar.GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(bottomStart, bottomBarTarget, total);
            }
            timer = 0;
            while(timer < (totalTime)){
                yield return null;
                timer += Time.deltaTime;
                float total = timer / (totalTime);
                //middleBar.GetComponent<RectTransform>().localScale = Vector3.Lerp(middleStart, middleBarTarget, total);
                middleBar.GetComponent<RectTransform>().position = Vector3.Lerp(middleStart, middleBarTarget, total);
            }
            Debug.Log("End");

            if(newScene != ""){
                SceneManager.LoadScene(newScene);
            }
        }

    }

    public void BarTransitionOff(){
         StartCoroutine(BarTransitionRoutineOff());
        IEnumerator BarTransitionRoutineOff(){
            Vector3 topPos = topBar.transform.position;
            float timer = 0;
            while(timer < (totalTime)){
                yield return null;
                timer += Time.deltaTime;
                float total = timer / (totalTime);
                //middleBar.GetComponent<RectTransform>().localScale = Vector3.Lerp(middleStart, middleBarTarget, total);
                middleBar.GetComponent<RectTransform>().position = Vector3.Lerp(middleStart, middleBarReset, total);
            }
            timer = 0;
            while(timer < totalTime){
                yield return null;
                timer += Time.deltaTime;
                float total = timer / totalTime;
                topBar.GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(topStart, topBarReset, total);
                bottomBar.GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(bottomStart, bottomBarReset, total);
            }
        }
    }

    // Update is called once per frame

}