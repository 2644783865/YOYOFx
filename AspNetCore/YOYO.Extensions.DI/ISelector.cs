using Microsoft.Extensions.DependencyInjection;

namespace YOYO.Extensions.DI
{
    /// <summary>
    /// ѡ����
    /// </summary>
    internal interface ISelector
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        void Populate(IServiceCollection services);
    }
}