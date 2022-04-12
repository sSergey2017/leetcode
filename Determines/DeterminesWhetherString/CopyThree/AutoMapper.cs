using AutoMapper;


namespace CopyThree
{
    public static class AutoMapper
    {
        private static readonly Mapper Mapper;

        static AutoMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TreeA, TreeB>());
            Mapper = new Mapper(config);
        }

        public static TreeB Map(TreeA tree) { return Mapper.Map<TreeB>(tree); }

    }
}
