using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace VideoAdvertising.Authentication.TwitchAuthentication
{
    public static class TwitchAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Twitch
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="options">Middleware configuration options</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseTwitchAuthentication(this IAppBuilder app, TwitchAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(TwitchAuthenticationMiddleware), app, options);
            return app;
        }

        /// <summary>
        /// Authenticate users using Facebook
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="clientId">The appId assigned by Facebook</param>
        /// <param name="clientSecret">The appSecret assigned by Facebook</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseTwitchAuthentication(
            this IAppBuilder app,
            string clientId,
            string clientSecret)
        {
            return UseTwitchAuthentication(
                app,
                new TwitchAuthenticationOptions
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                });
        }
    }
}