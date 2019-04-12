using Abp.DataDictionaryManagement.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.DataDictionaryManagement
{
    public class DataDictionaryAppService : AsyncCrudAppService<DataDictionary, DataDictionaryQueryDto, int, DataDictionaryGetAllInput, DataDictionaryDto, DataDictionaryDto>, IDataDictionaryAppService
    {
        public DataDictionaryAppService(IRepository<DataDictionary, int> dataDictionaryRepository)
            : base(dataDictionaryRepository)
        {
        }

        protected override DataDictionary MapToEntity(DataDictionaryDto createInput)
        {
            return new DataDictionary
            {
                DictCode = createInput.DictCode,
                DictValue = createInput.DictValue,
                DictValueType = createInput.DictValueType,
                ParentId = createInput.ParentId,
                Sort = createInput.Sort,
                TypeCode = createInput.TypeCode,
                TypeName = createInput.TypeName
            };
        }

        protected override DataDictionaryQueryDto MapToEntityDto(DataDictionary entity)
        {
            return new DataDictionaryQueryDto
            {
                DictCode = entity.DictCode,
                DictValue = entity.DictValue,
                DictValueType = entity.DictValueType,
                ParentId = entity.ParentId,
                Sort = entity.Sort,
                TypeCode = entity.TypeCode,
                TypeName = entity.TypeName
            };
        }


    }
}