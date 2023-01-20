namespace DrcashPartner.Models;

public class RegisterPatient
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string CPF { get; set; }
    public string Birthdate { get; set; }
    public string PhoneNumber { get; set; }
    public bool isSmartPhone { get; set; }
}