namespace BusinessLogic.Domain;
public class UserChannel : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid ChannelId { get; set; }
    public User User { get; set; } = null!;
    public Channel Channel { get; set; } = null!;
    public string Role { get; set; } = string.Empty;

}