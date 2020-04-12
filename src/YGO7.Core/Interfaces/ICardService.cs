﻿using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
    public interface ICardService
    {
        //Task<ISingleResult<Card>> List();

        Card Get(string id);

        Card Create(Card entity);

        void Update(string id,Card entity);

        void Remove(string id);
    }
}