﻿using Task3;

var account=new BankAccount(); 
account.AccountNumber=11113013; 
account.TopUp(7843); 
account.Withdraw(239); 
var balance=account.PrintStatement();
System.Console.WriteLine($"Account :{account.AccountNumber} has {balance} USD in balance");