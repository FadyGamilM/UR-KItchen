using MediatR;
using Microsoft.EntityFrameworkCore;
using UrKitchen.Persistance;
using UrKitchen.Persistance.Data;

var builder = WebApplication.CreateBuilder(args);
{
    //! the sdk default services
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //! Inject services for persistance layer
    // ==> get the assembly of the persistance project
    var persistanceAssembly = typeof(UrKitchen.Persistance.AssemblyReference).Assembly;
    // ==> inject the MediatR as a service 
    builder.Services.AddMediatR(persistanceAssembly); 

    //! Inject the Db Context and connect to the database
    //*=> connect to postgres through the AppDbContext
    builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDbContext>(
        options => options.UseNpgsql(
            builder.Configuration.GetConnectionString("conn")
        )
    );
}


var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
