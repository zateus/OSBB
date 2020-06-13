using BLL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using BLL.DTO;
using ClassLibrary1.Repositories.Interfaces;
using AutoMapper;
using ClassLibrary1.UnitOfWork;
using CCL;
using CCL.Security.Identity;

namespace Catalog.BLL.Services.Impl
{
    public class TemperatureDataService
        : ITemperatureDataService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;

        public TemperatureDataService(
            IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(
                    nameof(unitOfWork));
            }
            _database = unitOfWork;
        }

        /// <exception cref="MethodAccessException"></exception>
        public IEnumerable<TemperatureDataDTO> GetTemperatureDatas(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Statistic))
                
            {
                throw new MethodAccessException();
            }
            var osbbId = user.InquiryID;
            var TemperatureDatasEntities =
                _database
                    .TemperatureDatas
                    .Find(z => z.TemperatureDataID == osbbId, pageNumber, pageSize);
            var mapper =
                new MapperConfiguration(
                    cfg => cfg.CreateMap<TemperatureData, TemperatureDataDTO>()
                    ).CreateMapper();
            var TemperatureDatasDto =
                mapper
                    .Map<IEnumerable<TemperatureData>, List<TemperatureDataDTO>>(
                        TemperatureDatasEntities);
            return TemperatureDatasDto;
        }

        public void AddTemperatureData(TemperatureDataDTO TemperatureData)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Statistic))
                
            {
                throw new MethodAccessException();
            }
            if (TemperatureData == null)
            {
                throw new ArgumentNullException(nameof(TemperatureData));
            }

            validate(TemperatureData);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TemperatureDataDTO, TemperatureData>()).CreateMapper();
            var TemperatureDataEntity = mapper.Map<TemperatureDataDTO, TemperatureData>(TemperatureData);
            _database.TemperatureDatas.Create(TemperatureDataEntity);
        }

        private void validate(TemperatureDataDTO TemperatureData)
        {
            if (TemperatureData.Temperature==0)
            {
                throw new ArgumentException("Name повинне містити значення!");
            }
        }
    }
}
