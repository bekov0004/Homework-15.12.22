public class User
{
    public string Firstname = "Anushervon ", Lastname = "Bekov",Username = "Bekov2004", Password = "SoftClub";
    public bool IsLoggedOn ;

    public void Login(string username, string password)
    {
         if(username==Username && password==Password){
            IsLoggedOn = true;
            Console.WriteLine("User logged successfully");
         }
         else{
            Console.WriteLine("Your password or username is incorrect");
         }
    }
    public void Logout(){
      IsLoggedOn=false;
    }

    public string GetFullInfo(){
      return $"{Firstname} {Lastname} {IsLoggedOn}";
    }

}