using System.Text;
using BusinessLogic.Application.Interfaces;
using BusinessLogic.Application.Models.Channels;
using BusinessLogic.Domain;
using BusinessLogic.Infrastructure.Models;
using BusinessLogic.Persistence;
using BusinessLogic.Persistence.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace BusinessLogic.Infrastructure.NetworkCalls.MessageQueue;
public class MessageQueueHelper
{
    public static Task SubscribeToRegisterUsersQueue(IModel channel)
    {
        var consumer = new EventingBasicConsumer(channel);
        var options = new DbContextOptions<ApplicationDbContext>();
        var dbcontext = new ApplicationDbContext(options);
        IUserRepository userRepository = new UserRepository(dbcontext);
        consumer.Received += async (ch, ea) =>
         {
             var userEncoded = ea.Body.ToArray();
             var userDecoded = Encoding.UTF32.GetString(userEncoded);
             UserWriteModel userDeserialialized = JsonConvert.DeserializeObject<UserWriteModel>(userDecoded);
             await userRepository.AddAsync(userDeserialialized.Adapt<User>());
             await userRepository.Save();
         };
        var channelTag = channel.BasicConsume("Authentication.User", true, consumer);
        return Task.CompletedTask;
    }
}