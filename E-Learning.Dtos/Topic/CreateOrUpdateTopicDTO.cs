using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Dtos.Topic
{
    public class CreateOrUpdateTopicDTO
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public Guid SubCategoryId {  get; set; }
    }
}
