using System.Reflection;

Console.WriteLine(typeof(Polly.Policy).Assembly.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "?");
