using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
// using Newtonsoft.Json;
using UnityEngine.UI;


public class PlayFabControls : MonoBehaviour
{

    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    // Register/Login/ResetPassword (Episode 6)
    public void RegisterButton() {
        IDictionary (passwordInput.text.Length < 6){
            messageText.text = "Passsword too short!";
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
    public void LoginButton() { }
    public void ResetPasswordButton() { }
    void OnPasswordReset(SendAccountRecoveryEmailResult result) { }




/*
    #region previousEpisodes
    // Logging in (Episode 2)
    void Start()
    void Login()
    void OnLoginSuccess(LoginResult result);

    //Player data (Episode 3)
    public void GetAppearance()
    void OnDataRecieved(GetUserDataResult result)
    public void SaveAppearance()
    void OnDataSend(UpdateUserDataResult result)

    //Title data (Episode 4)
    void GetTitleData()
    void OnCharactersDataRecieved(GetUserDataResult result)
    #endregion
*/

    //Other
    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }























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
