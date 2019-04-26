using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace Abp.DataDictionaryManagement
{
    public class DataDictionaryCacheItemInvalidator : ILocalEventHandler<EntityChangedEventData<DataDictionary>>, ITransientDependency
    {
        protected IDistributedCache<DataDictionaryCacheItem> Cache { get; }

        public DataDictionaryCacheItemInvalidator(IDistributedCache<DataDictionaryCacheItem> cache)
        {
            Cache = cache;
        }

        public virtual async Task HandleEventAsync(EntityChangedEventData<DataDictionary> eventData)
        {
            //var cacheKey = CalculateCacheKey(
            //    eventData.Entity.Name,
            //    eventData.Entity.ProviderName,
            //    eventData.Entity.ProviderKey
            //);

            //await Cache.RemoveAsync(cacheKey);
        }

        protected virtual string CalculateCacheKey(string name, string providerName, string providerKey)
        {
            return DataDictionaryCacheItem.CalculateCacheKey(name, providerName, providerKey);
        }
    }
}
