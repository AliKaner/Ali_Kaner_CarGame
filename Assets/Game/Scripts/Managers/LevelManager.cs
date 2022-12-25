using Game.Car.Base;
using UnityEngine;
using Game.ControlSystem.Controllers;

namespace Game.LevelSystem.Level

{
public class LevelManager : MonoBehaviour
{
    public CarBase playersCar;

    private int roundCount = 0;
    private CarBase[] cars;

    public void ResetLevel()
    {
        roundCount = 0;
        playersCar = cars[roundCount];
    }

    public void NextRound()
    {
        if (roundCount == 7)
        {
            ResetLevel();
        }

        roundCount++;
        playersCar = cars[roundCount];
    }

    public void StartRound()
    {
        for (int i = 0; i < roundCount - 1; i++)
        {
            cars[i].PlayRecord();
        }
        playersCar.gameObject.AddComponent<CarController>();
    }
}
}