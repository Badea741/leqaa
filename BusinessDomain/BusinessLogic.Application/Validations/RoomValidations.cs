using BusinessLogic.Application.Commands.Rooms.AddRoom;
using FluentValidation;

namespace BusinessLogic.Application.Validations;
public class RoomValildations : AbstractValidator<AddRoomCommand>
{
    public RoomValildations()
    {

    }
}