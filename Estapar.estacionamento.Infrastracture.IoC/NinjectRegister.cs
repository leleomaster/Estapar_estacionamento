using Estapar.estacionamento.application;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.infrastructure.repository;
using Estapar.estacionamento.infrastructure.repository.Repositories;
using Ninject;

namespace Estapar.estacionamento.Infrastracture.IoC
{
    public static class NinjectRegister
    {
        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        public static void RegisterServices(IKernel kernel)
        {
            // Web
            // kernel.Bind<ICallAPIHttpClient<PessoaViewModel>>().To<CallAPIHttpClient<PessoaViewModel>>();
            // kernel.Bind<ICallAPIHttpClient<BancoViewModel>>().To<CallAPIHttpClient<BancoViewModel>>();


            // AplicationService
            kernel.Bind<IManobraCarroService>().To<ManobraCarroService>();
            kernel.Bind<IMarcaCarroService>().To<MarcaCarroService>();
            kernel.Bind<IModeloCarroService>().To<ModeloCarroService>();
            kernel.Bind<IPessoaService>().To<PessoaService>();

            // Repositories
            kernel.Bind<IManobraCarroRepository>().To<ManobraCarroRepository>();
            kernel.Bind<IMarcaCarroRepository>().To<MarcaCarroRepository>();
            kernel.Bind<IModeloCarroRepository>().To<ModeloCarroRepository>();
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IFactoryConnection>().To<FactoryConnection>();

        }
    }
}
