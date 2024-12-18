using AutoMapper;

namespace App.Web
{
    public class MapperConfig
    {
        public static T2 InitializeAutomapper<T1,T2>(T1 entity)
        {           
            var config = new MapperConfiguration(cfg =>
            {                
                cfg.CreateMap<T1, T2>();       
            });          
            var mapper = new Mapper(config);
            T2 viewModel= mapper.Map< T1 ,T2 >(entity);
            return viewModel;
        }



    }
}
