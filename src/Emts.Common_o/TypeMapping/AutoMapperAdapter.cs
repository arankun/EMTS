using AutoMapper;

namespace Emts.Common.TypeMapping {
    public class AutoMapperAdapter : IAutoMapper {
        public T Map<T>(object objectToMap) {
            return Mapper.Map<T>(objectToMap);
        }
    }
}
