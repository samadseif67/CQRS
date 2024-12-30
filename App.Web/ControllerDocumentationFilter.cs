using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.ComponentModel;
using System.Reflection;

public class ControllerDescriptionDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        // استخراج تمامی مسیرها و کنترلرها
        foreach (var apiDescription in context.ApiDescriptions)
        {
            // بررسی اینکه ActionDescriptor از نوع ControllerActionDescriptor است
            if (apiDescription.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                // دریافت نوع کنترلر
                var controllerType = controllerActionDescriptor.ControllerTypeInfo.AsType();

                // بررسی وجود DescriptionAttribute
                var descriptionAttribute = controllerType.GetCustomAttribute<DescriptionAttribute>();
                if (descriptionAttribute != null)
                {
                    // اعمال توضیحات به مسیر Swagger
                    foreach (var path in swaggerDoc.Paths.Where(p => p.Key.Contains(apiDescription.RelativePath)))
                    {
                        path.Value.Description = descriptionAttribute.Description;
                    }
                }
            }
        }
    }
}
