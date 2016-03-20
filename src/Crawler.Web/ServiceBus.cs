using System;
using Akka.Actor;
using Akka.Routing;
using Crawler.Web.Actors;

namespace Crawler.Web
{
    public class ServiceBus
    {
        public static ServiceBus Instance => new Lazy<ServiceBus>().Value;
        
        private ServiceBus()
        {
            Console.WriteLine("Starting Actor System");
            
            var ActorSystem = Akka.Actor.ActorSystem.Create("webcrawler");
            var router = ActorSystem.ActorOf(Props.Empty.WithRouter(FromConfig.Instance), "tasker");
            
            //CommandProcessor = ActorSystem.ActorOf(Props.Create(() => new CommandProcessor(router)), "commands");
            SignalRActor = ActorSystem.ActorOf(Props.Create(() => new SignalRActor()), "signalr");
        }
        
        public IActorRef CommandProcessor { get; private set; }
        public IActorRef SignalRActor { get; private set; }
    }
}