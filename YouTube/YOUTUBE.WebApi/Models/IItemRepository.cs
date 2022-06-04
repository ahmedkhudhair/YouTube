using System;
using System.Collections.Generic;

using YOUTUBE.Core.Models;

namespace YOUTUBE.WebApi.Models
{
    // TODO WTS: Replace or update this interface when no longer using sample data.
    public interface IItemRepository
    {
        void Add(SampleCompany item);

        void Update(SampleCompany item);

        SampleCompany Remove(string id);

        SampleCompany Get(string id);

        IEnumerable<SampleCompany> GetAll();
    }
}
