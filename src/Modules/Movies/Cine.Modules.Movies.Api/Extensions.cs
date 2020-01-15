using Cine.Modules.Movies.Api.Services;
using Cine.Modules.Movies.Api.Validators;
using Convey;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Cine.Modules.Movies.Api
{
    public static class Extensions
    {
        public static IConveyBuilder AddMoviesModule(this IConveyBuilder builder)
        {
            builder.Services.AddSingleton<IMovieDtoValidator, MovieDtoValidator>();
            builder.Services.AddSingleton<IMoviesService, MoviesService>();

            return builder;
        }

        public static IApplicationBuilder UseMoviesModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}