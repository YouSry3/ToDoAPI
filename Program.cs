
        using Microsoft.EntityFrameworkCore;
        using Microsoft.EntityFrameworkCore.SqlServer;

        using ToDoApi.Data;

            var builder = WebApplication.CreateBuilder(args);

// 1. Add DbContext
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<ToDoContext>(options =>
        options.UseSqlServer(connectionString));


// 2. Add Swagger services
builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // 3. Add Controllers
            builder.Services.AddControllers()
                     .AddJsonOptions(options =>
                     {
                         options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                     });

var app = builder.Build();

            // 4. Swagger middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(); // <-- دي بتعرض واجهة Swagger
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();

