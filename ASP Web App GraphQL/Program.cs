global using GraphQL.Types;
using ASP_Web_App_GraphQL.Queries;
using ASP_Web_App_GraphQL.Queries.Base;
using ASP_Web_App_GraphQL.Queries.Interfaces;
using ASP_Web_App_GraphQL.Schema;
using ASP_Web_App_GraphQL.Services;
using GraphQL;
using GraphQL.MicrosoftDI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IDataProvider, DataProvider>();

// Queries
builder.Services.AddSingleton<IGraphQuery, PersonQuery>();
builder.Services.AddSingleton<IGraphQuery, ProductQuery>();

builder.Services.AddSingleton<ISchema, Schemas>(services => new Schemas(new SelfActivatingServiceProvider(services)));

builder.Services.AddGraphQL(opt =>
{
    opt.AddSystemTextJson();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseGraphQLAltair("/ui/graphql");
app.UseGraphQL<ISchema>();

app.Run();
