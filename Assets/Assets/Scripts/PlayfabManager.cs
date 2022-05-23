using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayfabManager : MonoBehaviour
{
    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    // Register/Login/ResetPassword (Episode 6)


    public void RegisterButton() {
        if (passwordInput.text.Length < 6)
        {
            messageText.text = "Password too short!";
            return;
        }

        var request = new RegisterPlayFabUserRequest{
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in!";
    }
    public void LoginButton() {
        var request = new LoginWithEmailAddressRequest{
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    } 

    public void ResetPasswordButton() {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "70500"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }
    void OnPasswordReset(SendAccountRecoveryEmailResult result) {
        messageText.text = "Password reset mail sent!";
    }



    //Logging in (Episode 2)
    void Start()
    {
        Login();
    }

    void Login(){
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnError);
    }

    void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Successful login/account create!");
        string name = null;
        if (result.InfoResultPayload.PlayerProfile != null)
        name = result.InfoResultPayload.PlayerProfile.DisplayName;
        return;

        if (name != null)
            SceneManager.LoadScene("titleScreen");
        return;
    }

    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log("Error while loggin in/creating account!");
        Debug.Log(error.GenerateErrorReport());
    }

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