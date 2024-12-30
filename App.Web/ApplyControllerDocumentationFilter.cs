using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

//public class ApplyControllerDocumentationFilter : IOperationFilter
//{
//    public void Apply(OpenApiOperation operation, OperationFilterContext context)
//    {
//        var controllerSummary = context.MethodInfo.DeclaringType?
//            .GetCustomAttributes(typeof(SummaryAttribute), true)
//            .Cast<SummaryAttribute>()
//            .FirstOrDefault();

//        if (controllerSummary != null)
//        {
//            operation.Summary = controllerSummary.Description;
//        }
//    }
//}
