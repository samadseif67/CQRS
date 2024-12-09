using Entites.Attribute;
using Entites.Repository;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//*************************************************************************
builder.Services.AddControllers()
    .AddFluentValidation(fv =>
    {
        
        fv.RegisterValidatorsFromAssembly(Assembly.Load("Entites"));//نام پروژه ای که تمام اعتبارسنجی ها فلونت ولیدیشن ست شده است
        fv.DisableDataAnnotationsValidation = false;
        
    });
//******************************************************************************

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//********************************************************************
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
 



//**********************************************************************




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
