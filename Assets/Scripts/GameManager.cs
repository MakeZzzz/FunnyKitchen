using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    
    // [SerializeField] private KitchenZoneInitializer _configSystem;
    // // private SaveSystem _json;
    //
    // private void Awake()
    // {
    //     //_json = new SaveSystem();
    //     StartGame();
    // }
    //
    // private void StartGame()
    // {
    //     BusinessModel[] _businessModels;
    //     var data = _json.Load();
    //     if (data == null)
    //     {
    //         Debug.Log("IF");
    //         Debug.Log(totalBalanceController.GetBalance());
    //         _configSystem.CreateBusinessModels();
    //         _businessModels = _configSystem.GetBuisnessModels();
    //     }
    //     else
    //     {
    //         Debug.Log("ELSE");
    //         _businessModels = data.BusinessModels;
    //         Debug.Log(data.Balance);
    //
    //         totalBalanceController.Initialize(data.Balance);
    //     }
    //
    //     businessSystem.SpawnBusiness(_businessModels);
    // }

    // [UsedImplicitly]
    // public void ExitWithSaving()
    // {
    //     var businesModels = _configSystem.GetBuisnessModels();
    //
    //     var balance = totalBalanceController.GetBalance();
    //     var saveData = new SaveData(balance, businesModels);
    //
    //     _json.Save(saveData);
    //
    //
    //     EditorApplication.isPlaying = false;
    // }
    //
    // [UsedImplicitly]
    // public void ExitWithoutSaving()
    // {
    //     _json.Delete();
    //     businessSystem.DeleteControllers();
    //     EditorApplication.isPlaying = false;
    // }
}