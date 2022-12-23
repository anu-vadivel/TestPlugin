using Microsoft.Extensions.Logging;

namespace {{cookiecutter.Namespace}}.{{cookiecutter.ProjectName}}Plugin;

public class {{cookiecutter.ProjectName}}Plugin : {{cookiecutter.PluginInterface}}
{
   private readonly ILogger<{{cookiecutter.ProjectName}}Plugin> _logger;

   public {{cookiecutter.ProjectName}}Plugin(ILogger<{{cookiecutter.ProjectName}}Plugin> logger)
   {
      _logger = logger;
   }

   public void MakePayment()
   {
      _logger.LogInformation("I am in payment");
   }
}
