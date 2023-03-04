using BusinessLogic.Application.CommandInterfaces;
using BusinessLogic.Application.Interfaces;
using BusinessLogic.Application.Models.Channels;
using BusinessLogic.Application.Models.Posts;
using BusinessLogic.Domain;
using BusinessLogic.Domain.DomainErrors;
using ErrorOr;
using Mapster;
using MediatR;
using System.Runtime.CompilerServices;

namespace BusinessLogic.Application.Commands.Posts.AddaPost;
public class AddPostCommandHandler : IHandler<AddPostCommand, ErrorOr<PostWriteModel>>
{
    private readonly IPostRepository _PostRepository;
    private readonly IHubRepository _hubRepository;
    private readonly IUserRepository _userRepository;

    public AddPostCommandHandler(
        IPostRepository postRepository,
        IHubRepository hubRepository,
        IUserRepository userRepository
        )
    {
        _PostRepository = postRepository;
        _hubRepository = hubRepository;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<PostWriteModel>> Handle(AddPostCommand request, CancellationToken cancellationToken)
    {
        User? creatorUser = (await _userRepository.GetAsync(u => u.UserName == request.Username)).FirstOrDefault();

        if (creatorUser is null)
        {
            return DomainErrors.User.NotFound;
        }

        string username = request.Username;
        request = request with { Username = username };
        var post = request.Adapt<Post>();

        creatorUser.Posts.Add(post);


        var postmodel = post.Adapt<PostWriteModel>();
        if (await _PostRepository.SaveAsync(cancellationToken) == 0)
        {
            return DomainErrors.Channel.InvalidChannel;
        }
        return postmodel;
    }


}