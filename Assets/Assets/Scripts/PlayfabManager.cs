using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
//using PlayFab.DataModels;
//using PlayFab.ProfilesModels;
//using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayfabManager : MonoBehaviour
{
    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    // Register/Login/ResetPassword (Episode 6)
    public static string strEmail;
    public static string strRole;
    public static int intTheme;


    void Start()
    {
       Login();
    }




    private bool ValidateEmail(string strEmail)
    {
        bool bolResult = false;
        Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        Match match = regex.Match(strEmail);
        if (match.Success)
        {
            bolResult = true;
        }
        else
        {
            bolResult = false;
        }

        return bolResult;
    }

    private bool ValidateEmail2(string strEmail)
    {

        if ((strEmail).Contains("@gmail.com"))
        {
            return true;
        }
        if ((strEmail).Contains("@cavsafe.com"))
        {
            return true;
        }
        if ((strEmail).Contains("@yahoo.com"))
        {
            return true;
        }

        return false;
    }

    private string ValidateRole(string strEmail)
    {

        if ((strEmail).Contains("@gmail.com"))
        {
            return "normal";
        }
        if ((strEmail).Contains("@cavsafe.com"))
        {
            return "admin";
        }
        if ((strEmail).Contains("@yahoo.com"))
        {
            return "normal";
        }

        return "normal";
    }


    public void RegisterButton()
    {

        if (passwordInput.text.Length < 6)
        {
            messageText.text = "Password too short!";
            return;
        }

        if (ValidateEmail2(emailInput.text) == false)
        {
            messageText.text = "Invalid email address!";
            return;
        }

      
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }


    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in!";
        SaveRole();
    }
      

    public void SaveRole()
    {
        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string> {
                { "Role", "Normal" }
            }
        };
        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }

    void OnDataSend(UpdateUserDataResult result)
    {
        Debug.Log("User Data Added");

    }


    public void GetRole()
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataReceived, OnError);
    }

    void OnDataReceived(GetUserDataResult result)
    {
        if (result.Data != null && result.Data.ContainsKey("Role"))
        {
            PlayerPrefs.SetString("Role", result.Data["Role"].Value.ToString());
            PlayerPrefs.Save();
            Debug.Log("with Role");
        }
        else
        {
            PlayerPrefs.SetString("Role", "Guest");
            PlayerPrefs.Save();
            Debug.Log("guest Role");
        }
    }
      

    public void GetTheme()
    {
        PlayFabClientAPI.GetTitleData(new GetTitleDataRequest(), OnTitleDataReceived, OnError);
    }

    void OnTitleDataReceived(GetTitleDataResult result)
    {
        //if (result.Data != null || result.Data.ContainsKey("Theme"))
        //{
        //    PlayerPrefs.SetString("Theme", result.Data["Theme"]);
        //    PlayerPrefs.Save();

        //    Debug.Log("with Theme");
        //}
        //else
        //{       
        //    PlayerPrefs.SetString("Theme", "No Theme");
        //    PlayerPrefs.Save();

        //    Debug.Log("guest Theme");
        //}

        if (PlayerPrefs.GetString("Role") == "Admin")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("AdminYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("AdminGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("AdminRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("AdminBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("AdminViolet");
            }
            else
            {
                SceneManager.LoadScene("adminScreen");
            }

        }
        else if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("NormalYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("NormalGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("NormalRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("NormalBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("NormalViolet");
            }
            else
            {
                SceneManager.LoadScene("titleScreen");
            }
        }
        else
        {
            SceneManager.LoadScene("GuestScreen");
        }

    }


  



    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };

        PlayerPrefs.SetString("Message", "Welcome " + emailInput.text + "!");
        PlayerPrefs.Save();

        Debug.Log("Current user is " + emailInput.text);
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    void OnLoginSuccess(LoginResult result)
    {
        GetRole();
        GetTheme();      

  
    }


    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "70500"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }
    void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Password reset mail sent!";
    }

    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };

    }

    
    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }

    void StartAdmin()
    {
        //Debug.Log("Current user is " + emailInput.text);
        Debug.Log("CavSafe App Start!");
        SceneManager.LoadScene("adminScreen");
    }

    void StartNormal()
    {
        Debug.Log("CavSafe App Start!");
        SceneManager.LoadScene("titleScreen");
    }

    void StartGuest()
    {
        Debug.Log("CavSafe App Start!");
        SceneManager.LoadScene("GuestScreen");
    }

    public void LogoutButton()
    {
        Debug.Log("Logged out!");
        PlayFabClientAPI.ForgetAllCredentials();
        messageText.text = "Logged Out!";

        SceneManager.LoadScene("Login");
    }
   
    public void LogoutButton2()
    {
        SceneManager.LoadScene("Login");
    }

    //MAIN BUTTONS
    public void SafetyTipsScene()
    {
        if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("SafetyTipsYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("SafetyTipsGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("SafetyTipsRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("SafetyTipsBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("SafetyTipsViolet");
        }
        else
        {
            SceneManager.LoadScene("SafetyTips");
        }
    }
    public void UserGuideScene()
    {
        if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("yellowhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("greenhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("redhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("blackhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("violethelp");
        }
        else
        {
            SceneManager.LoadScene("bluehelp");
        }
    }
    //public void LoginButtonTitleScreen()
    //{
    //    SceneManager.LoadScene("Login");
    //}

    public void titleScreen()
    {
        if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("NormalYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("NormalGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("NormalRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("NormalBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("NormalViolet");
        }
        else
        {
            SceneManager.LoadScene("titleScreen");
        }
    }
    public void Map()
    {
        SceneManager.LoadScene("Map");
    }
}
