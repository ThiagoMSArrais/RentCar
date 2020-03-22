﻿using System;
using TMSA.RentCar.Core.Domain.Interfaces;

namespace TMSA.RentCar.Core.Domain.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public int Versao { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Versao = 1;
            this.Key = key;
            this.Value = value;
            this.DataOcorrencia = DateTime.Now;
        }
    }
}