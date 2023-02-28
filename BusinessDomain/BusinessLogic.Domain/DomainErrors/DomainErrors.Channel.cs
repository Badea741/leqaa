using ErrorOr;

namespace BusinessLogic.Domain.DomainErrors;
public static partial class DomainErrors
{
    public static class Channel
    {
        public static Error NotFound => Error.NotFound("Channel.NotFound", "channel not found, create channel");
        public static Error InvalidChannel => Error.Failure("Channel.InvalidChannel", "Invalid Channel, couldn't complete your request");
    }



    public static class Room
    {
        public static Error InvalidRoom => Error.Failure("Room.InvalidChannel", "Invalid Room, couldn't complete your request");
    }


    public static class Post
    {
        public static Error InvalidPost => Error.Failure(".InvalidPost", "Invalid Post, couldn't complete your request");
    }
}