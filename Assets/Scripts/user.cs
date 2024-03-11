[System.Serializable]
public class User
{
    public string UserId;
    public string Username;
    public string Email;
    public int Score;

    public User(){}  //default for json serialization

    public User(string userId, string username, string email, int score)
    {
        UserId = userId;
        Username = username;
        Email = email;
        Score = score;
    }
}
