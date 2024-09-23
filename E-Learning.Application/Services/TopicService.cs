using AutoMapper;
using E_Learning.Application.Contract;
using E_Learning.Application.IService;
using E_Learning.Dtos.Topic;
using E_Learning.Dtos.ViewResult;
using E_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Application.Services
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;
        public TopicService(ITopicRepository topicRepository, IMapper mapper)
        {
            _mapper = mapper;
            _topicRepository = topicRepository;
        }
        public Task<ResultView<CreateOrUpdateTopicDTO>> CreateTopicAsync(Topic topic)
        {
            throw new NotImplementedException();
        }

        public Task<ResultView<List<GetAllTopicDTO>>> GetAllTopicsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultView<GetAllTopicDTO>> GetTopicAsync(Guid topicId)
        {
            throw new NotImplementedException();
        }

        public Task<ResultView<CreateOrUpdateTopicDTO>> HardDeleteTopicAsync(Guid topicId)
        {
            throw new NotImplementedException();
        }

        public Task<ResultView<CreateOrUpdateTopicDTO>> SoftDeleteTopicAsync(Guid topicId)
        {
            throw new NotImplementedException();
        }

        public Task<ResultView<CreateOrUpdateTopicDTO>> UpdateTopicAsync(Topic topic)
        {
            throw new NotImplementedException();
        }
    }
}
