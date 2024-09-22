using Microsoft.Extensions.DependencyInjection;

namespace RentACar.ConsoleUI.Interface;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class InjectableAttribute : Attribute
{
    public ServiceLifetime LifeTime { get; }

    public InjectableAttribute(ServiceLifetime lifetime = ServiceLifetime.Transient)
    {
        this.LifeTime = lifetime;
    }
}