using student;

var account = new BackAccount();
account.Id = 1;
account.Name = "Test";
account.Rate = 10;

account.SetPassword("1234");

var newAccount = new NewAccount();
newAccount.Id = 1;

