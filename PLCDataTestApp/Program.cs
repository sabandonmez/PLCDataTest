using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Repositories.Models;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options=>{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b=> b.MigrationsAssembly("PLCDataTestApp"));
});

builder.Services.AddScoped<IRepositoryManager,RepositoryManager>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IMobusOperationModelRepository,MobusOperationModelRepository>();
builder.Services.AddScoped<ISiemensOperationModelRepository,SiemensOperationModelRepository>();


builder.Services.AddScoped<IServiceManager,ServiceManager>();
builder.Services.AddScoped<IProductService,ProductManager>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<IMobusOperationModelService,MobusOperationModelManager>();
builder.Services.AddScoped<ISiemensOperationModelService,SiemensOperationModelManager>();


var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=Modbus}/{action=Index}/{id?}");

app.Run();
