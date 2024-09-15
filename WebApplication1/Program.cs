namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            #region EndPointMapping
            //app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapGet("/home", async context =>
            //        {
            //            await context.Response.WriteAsync("HomePage");
            //        });

            //        //endpoints.MapGet("/products", async context =>
            //        //{
            //        //    await context.Response.WriteAsync("ProductsPage");
            //        //});

            //        endpoints.MapGet("/products/{ID:int?}", async context =>
            //        {
            //            var id = context.Request.RouteValues["ID"];
            //            if (id is not null)
            //            {
            //                await context.Response.WriteAsync($"ProductsPage id => {id}");
            //            }
            //            else
            //            {
            //                await context.Response.WriteAsync("ProductsPage");
            //            }
            //        });

            //        endpoints.MapGet("/books/{ID}/{Author:alpha:minlength(4):maxlength(6)}", async context =>
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //            string name = context.Request.RouteValues["Author"].ToString();
            //            await context.Response.WriteAsync($"BooksPage BookId => {id}, Author => {name}");
            //        });
            //    });
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new {Controller = "Home", Action = "Index"}
                );


            //app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Page Not Found 404"); });
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
