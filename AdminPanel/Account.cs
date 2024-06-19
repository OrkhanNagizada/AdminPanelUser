using System.Security.Cryptography.X509Certificates;

namespace _06._12._2024_2_;

public abstract class Account
{
    public abstract bool PasswordChecker(string password);
    public abstract void ShowInfo();
}