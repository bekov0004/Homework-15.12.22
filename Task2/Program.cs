 User LoginUser = new User(); 
 string usname,pasword;
 usname = Console.ReadLine();
 pasword = Console.ReadLine();
 LoginUser.Login(usname,pasword); 
 Console.WriteLine(LoginUser.GetFullInfo());