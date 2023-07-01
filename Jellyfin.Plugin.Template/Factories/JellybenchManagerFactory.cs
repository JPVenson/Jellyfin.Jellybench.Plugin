using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jellyfin.Plugin.Template.Services.JellybenchManager;
using MediaBrowser.Model.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Jellyfin.Plugin.Template.Factories
{
    /// <summary>
    /// Factory to create the <see cref="JellybenchManagerService"/>.
    /// </summary>
    public class JellybenchManagerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="JellybenchManagerFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">Service provider.</param>
        public JellybenchManagerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Creates the JellybenchManagerService.
        /// </summary>
        /// <returns>JellybenchManagerService.</returns>
        public JellybenchManagerService Create()
        {
            return new JellybenchManagerService(_serviceProvider.GetRequiredService<ITaskManager>());
        }
    }
}
