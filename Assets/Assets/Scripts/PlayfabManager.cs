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

    public void GetRole()
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataReceived, OnError);
    }

    public void GetTheme()
    {
        PlayFabClientAPI.GetTitleData(new GetTitleDataRequest(), OnTitleDataReceived, OnError);
    }

    void OnTitleDataReceived(GetTitleDataResult result)
    {
        if (result.Data == null || result.Data.ContainsKey("Theme") == false)
        {
            Debug.Log("No message");
            return;
        }
            
        //intTheme = int.Parse(result.Data["Theme"]);
        PlayerPrefs.SetString("Theme", result.Data["Theme"]);
        PlayerPrefs.Save();

    }

    void OnDataReceived(GetUserDataResult result)
    {
        if (result.Data != null && result.Data.ContainsKey("Role"))
        {
            PlayerPrefs.SetString("Role", result.Data["Role"].Value.ToString());
            PlayerPrefs.Save();
        }
        else
        {
            strRole = "Normal";       
        }

       

    }



    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {     
        messageText.text = "Registered and logged in!";
        SaveRole();
    }

    void OnDataSend(UpdateUserDataResult result)
    {
        Debug.Log("User Data Added");
        //Debug.Log("Registered and logged in!");
    }



    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        Debug.Log("Current user is " + emailInput.text);
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
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



    //Logging in (Episode 2)

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

    void OnLoginSuccess(LoginResult result)
    {
        GetTheme();
        GetRole();
                
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
                SceneManager.LoadScene("adminScreen");
            }
        }
        else
        {           
            SceneManager.LoadScene("GuestScreen");            
        }
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
        SceneManager.LoadScene("titleScreen");
    }

    public void LogoutButton()
    {
        Debug.Log("Logged out!");
        PlayFabClientAPI.ForgetAllCredentials();
        messageText.text = "Logged Out!";

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
    public void LoginButtonTitleScreen()
    {
        if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("LoginYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("LoginGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("LoginRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("LoginBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("LoginViolet");
        }
        else
        {
            SceneManager.LoadScene("Login");
        }
    }
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

    //void Update()
    //{
    //    if (Application.platform == RuntimePlatform.Android)
    //    {
    //        if (Input.GetKey(KeyCode.Escape))
    //        {
    //            Application.Quit();
    //        }
    //    }
    //}


    /*
        //Player data (Episode 3)
        public void GetAppearance()
        void OnDataRecieved(GetUserDataResult result)
        public void SaveAppearance()
        void OnDataSend(UpdateUserDataResult result)

        //Title data (Episode 4)
        void GetTitleData()
        void OnCharactersDataReceived(GetUserDataResult result)
    */


    /* [SerializeField] GameObject signUpTab, logInTab, startPanel, HUD;
     public Text username, userEmail, userPassword, userEmailLogin, userPasswordLogin, errorSignup, errorLogin;
     string encryptedPassword;

     public void SwitchToSignUpTab() {
         signUpTab.SetActive(true);
         logInTab.SetActive(false);
         errorSignup.text = "";
         errorLogin.text = "";
     }
     public void SwitchToLoginTab() {
         signUpTab.SetActive(false);
         logInTab.SetActive(true);
         errorSignup.text = "";
         errorLogin.text = "";
     }

     string Encrypt(string pass)
     {
         System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
         byte[] bs = System.TextEncoding.UTF8.GetBytes(pass);
         bs = x.ComputerHash(bs);
         System.Text.StringBuilder s = new System.Text.StringBuilder();
         foreach (byte b in bs)
         {
             s.Append(b.ToString("x2").ToLower());
         }
         return s.ToString();
     }

     public void SignUp() { 
         var registerRequest = new RegisterPlayFabUserRequest { Email = userEmail.text, Password = Encrypt(userPassword.text), Username = username.text };
         PlayFabClientAPI.RegisterPlayFabUser(registerRequest, RegisterSuccess, RegisterError);
     }

     public void RegisterSuccess(RegisterPlayFabUserResult result){
         errorSignUp.text = "";
         errorLogIn.text = "";
         StartGame();
 }
     public void RegisterError(PlayFabError error)
 {
     errorSignUp.text = error.GenerateErrorReport();

 }
     public void LogIn() {
         var request = new LogInWithEmailAddressRequest { Email = userEmailLogin.text, Password = Encrypt(userPasswordLogin.text), Username = username.text };
         PlayFabClientAPI.LogInWithEmailAddress(request, LogInSuccess, LogInError);
     }

     public void LogInSuccess(LoginResult result)
 {
     errorSignUp.text = "";
     errorLogIn.text = "";
     StartGame();
 }

     public void LogInError(PlayFabError error)
 {
     errorLogin.text = error.GenerateErrorReport();
 }
     void StartGame()
 {
     startPanel.SetActive(false);
     HUD.SetActive(true);
 }*/
}
