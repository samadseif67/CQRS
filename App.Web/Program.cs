using App.Web;
using Entites.Attribute;
using Entites.Repository;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Web.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//**********************************************************************

builder.Services.RegisterService(builder.Configuration);


//************************************************************************
//برای اینکه خروجی دقیقا همان خروجی باشد از لحاظر حروف بزرگ و کوچک
//HttpConfiguration config = GlobalConfiguration.Configuration;
//config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
//config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;



//*************************************************************************
builder.Services.AddControllers(options =>
{
    options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
     
}).AddFluentValidation(fv =>
    {

        fv.RegisterValidatorsFromAssembly(Assembly.Load("Entites"));//نام پروژه ای که تمام اعتبارسنجی ها فلونت ولیدیشن ست شده است
        fv.DisableDataAnnotationsValidation = false;

    });
//******************************************************************************

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    //   // فعال کردن مستندات XML
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    //اضافه کردن فیلتر توضیحات کنترلر
    options.DocumentFilter<ControllerDescriptionDocumentFilter>();
});

//********************************************************************






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
