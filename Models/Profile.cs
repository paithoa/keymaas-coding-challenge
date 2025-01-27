namespace UserManagementAPI.Models;

public class Profile
{
    public int Id { get; set; }
    public required string ProfileName { get; set; }
    public required string ProfileDescription { get; set; }
    public int UserId { get; set; }

    [System.Text.Json.Serialization.JsonIgnore] // Ignore during serialization
    public User? User { get; set; }
}
