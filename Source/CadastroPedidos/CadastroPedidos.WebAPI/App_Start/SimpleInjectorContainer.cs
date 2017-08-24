using CadastroPedidos.Core.Infra;
using CadastroPedidos.Core.Services.Usuario;
using CadastroPedidos.Repository;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace CadastroPedidos.WebAPI.App_Start
{
    public class SimpleInjectorContainer
    {
        public static Container Build()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IUsuarioRepository, UsuarioRepository>();
            container.Register<IUsuarioService, UsuarioService>();
            container.Register<Notification>(Lifestyle.Scoped);

            container.Verify();
            return container;
        }
    }
}