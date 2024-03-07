namespace Task3;

public class BankAccount
{ 
     public int AccountNumber { get; set; } 
    public decimal Balance { get; set; } 
    public string Owner { get; set; } 

    public void TopUp(decimal amount)
    {
    Balance+=amount;
    } 
    public void Withdraw(decimal amount)
    {
    Balance-=amount;
    } 
    public decimal PrintStatement()
    {
        return Balance;
    }
}