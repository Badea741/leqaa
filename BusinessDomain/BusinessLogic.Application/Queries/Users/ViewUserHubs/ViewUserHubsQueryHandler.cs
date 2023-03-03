﻿using BusinessLogic.Application.CommandInterfaces;
using BusinessLogic.Application.Commands.Channels.CreateChannel;
using BusinessLogic.Application.Interfaces;
using BusinessLogic.Application.Models.Channels;
using BusinessLogic.Application.Models.Hubs;
using BusinessLogic.Application.Queries.Users.ViewUserHubs;
using BusinessLogic.Domain;
using BusinessLogic.Domain.DomainErrors;
using ErrorOr;
using FluentValidation;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BusinessLogic.Application.Queries.Users.ViewUserHubs
{
public class ViewUserPostsQueryHandler : IHandler<ViewUserHubsQuery, ErrorOr<List<HubReadModel>>>
    {
        private readonly IChannelRepository _channelRepository;
        private readonly IHubRepository _hubRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserChannelRepository _userChannelRepository;

        public ViewUserPostsQueryHandler(
            IChannelRepository channelRepository,
            IHubRepository hubRepository,
            IUserRepository userRepository,
            IUserChannelRepository userChannelRepository)
        {
            _channelRepository = channelRepository;
            _hubRepository = hubRepository;
            _userRepository = userRepository;
            _userChannelRepository = userChannelRepository;
        }
        public async Task<ErrorOr<List<HubReadModel>>> Handle(ViewUserHubsQuery request, CancellationToken cancellationToken)
        {

            var user = await _userRepository.GetUserAsync(u => u.UserName == request.userName, "Hubs");
            if (user is null)
            {
                return DomainErrors.User.NotFound;
            }

            var Hubs=user.Hubs.ToList();

            
  
       
            if(Hubs.Count== 0)
            {
                return DomainErrors.Hub.NotFound;
            }

         

            return Hubs
            .Adapt<List<HubReadModel>>();




        }


    }
    
}