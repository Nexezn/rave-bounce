using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI peopleText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI riskText;
    [SerializeField] private GameObject winnerMenu;
    public static LevelManager main;
    public Transform startPoint;
    public Transform exitPoint;
    [Header("Attributes")]
    public int guestsChecked = 0;
    [SerializeField] float MaxMoney = 500.0f;
    [SerializeField] float MaxRisk = 100.0f;
    public float totalMoney = 0.0f;
    public float totalRisk = 0.0f;
    public Transform[] path;
    public GameObject[] pathObject;
    // Start is called before the first frame update
    void Start()
    {
        peopleText.text = "0";
        moneyText.text = "$0.0";
        riskText.text = "0.0";
    }

    // Update is called once per frame
    void Update()
    {
        peopleText.text = guestsChecked.ToString() + " guests";
        moneyText.text = "$"+ totalMoney.ToString();
        riskText.text = totalRisk.ToString();

        if (totalMoney >= MaxMoney){
            //Move onto next gameloop OR Provide win condition.
            Time.timeScale = 0;
            winnerMenu.SetActive(true);
        }
        else if (totalRisk >= MaxRisk){
            GoToMainMenu("MainMenu");
        }
    }
    public void GoToMainMenu( string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
